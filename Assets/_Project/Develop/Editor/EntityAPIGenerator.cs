using System.IO;
using UnityEngine;
using System.Text;
using UnityEditor;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using System.Reflection;
using System;
using System.Linq;
using System.Collections.Generic;
using Unity.VisualScripting;



namespace Assets._Project.Develop.Editor
{
    public class EntityAPIGenerator
    {

        private const string AssemblyName = "Assembly-CSharp";

        private static string OutputPath
            = Path.Combine(Application.dataPath, "_Project/Develop/Runtime/Configs/GamePlay/EntitiesCore/Generated/EntityAPI.cs");


        [MenuItem("Tools/GenerateEntityAPI")]
        private static void Generate()
        {
            Debug.Log("=== GENERATOR STARTED ===");
            Debug.Log($"Output path: {OutputPath}");
            Debug.Log($"File exists: {File.Exists(OutputPath)}");
            
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"namespace {typeof(Entity).Namespace}");
            sb.AppendLine("{");

            sb.AppendLine($"\tpublic partial class {typeof(Entity).Name}");
            sb.AppendLine("\t{");

            Assembly assembly = Assembly.Load(AssemblyName);

            IEnumerable<Type> componentTypes = GetComponentTypesFrom(assembly);

            foreach (Type componentType in componentTypes)
            {
                string typeName = componentType.Name;
                string fullTypeName = componentType.FullName;

                string componentName = RemoveSuffixIsExist(typeName,"Component");
                string modifiedComponentName = componentName + "C";

                //свойство для получения компонента
                sb.AppendLine($"\t\tpublic {fullTypeName} {modifiedComponentName} => GetComponent<{fullTypeName}>();");
                sb.AppendLine();

                if(HasSingleField(componentType, out FieldInfo field) && field.Name == "Value")
                {
                    sb.AppendLine($"\t\tpublic {GetValidTypeName(field.FieldType)} {componentName} => {modifiedComponentName}.{field.Name};");
                    sb.AppendLine();

                    //метод Try Get
                    sb.AppendLine($"\t\tpublic bool TryGet{componentName}(out {GetValidTypeName(field.FieldType)} {GetVariableNameFrom(field.Name)})");
                    sb.AppendLine("\t\t{");
                    sb.AppendLine($"\t\t\tbool result = TryGetComponent(out {fullTypeName} component);");
                    sb.AppendLine($"\t\t\tif(result)");
                    sb.AppendLine($"\t\t\t\t{GetVariableNameFrom(field.Name)} = component.{field.Name};");
                    sb.AppendLine($"\t\t\telse");
                    sb.AppendLine($"\t\t\t\t{GetVariableNameFrom(field.Name)} = default({GetValidTypeName(field.FieldType)});");
                    sb.AppendLine($"\t\t\treturn result;");
                    sb.AppendLine("\t\t}");
                    sb.AppendLine();





                    if (HasEmptyConstructor(field.FieldType))
                    {
                        string initializer = "{ " + field.Name + " = new " + GetValidTypeName(field.FieldType) + "() }";

                        sb.AppendLine($"\t\tpublic {typeof(Entity).FullName} Add{componentName}()");
                        sb.AppendLine("\t\t{");
                        sb.AppendLine($"\t\t\treturn AddComponent(new {fullTypeName}() {initializer}); ");
                        sb.AppendLine("\t\t}");
                        sb.AppendLine();

                    }



                }

                // метод add  с указанием параметров;
                string componentParametrs = GetParametrs(componentType);

                sb.AppendLine($"\t\tpublic {typeof(Entity).FullName} Add{componentName}({componentParametrs})");
                sb.AppendLine("\t\t{");
                sb.AppendLine($"\t\t\treturn AddComponent(new {fullTypeName}() {GetInitializer(componentType)}); ");
                sb.AppendLine("\t\t}");
                sb.AppendLine();

            }

            sb.AppendLine("\t}");

            sb.AppendLine("}");

            File.WriteAllText(OutputPath, sb.ToString());
            
            Debug.Log("=== FILE WRITTEN ===");
            Debug.Log($"Generated {componentTypes.Count()} components");

            AssetDatabase.Refresh();
            AssetDatabase.SaveAssets();
            
            Debug.Log("=== GENERATOR FINISHED ===");
        }


        private static bool HasEmptyConstructor(Type type)
        {
            return
                type.GetConstructor(Type.EmptyTypes) != null
                && type.IsSubclassOf(typeof(UnityEngine.Object)) == false;

        }






       private static string GetInitializer(Type type)
       {
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            if (fields.Any() == false)
                return "";

            IEnumerable<string> initializers = fields
                .Select(field => $"{field.Name} = {GetVariableNameFrom(field.Name)}");

            return "{" + string.Join(", ", initializers) + "}";

       }





        private static string GetParametrs(Type type)
        {
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            if (fields.Any() == false)
                return null;

            IEnumerable<string> parametrs = fields
                .Select(field => $"{GetValidTypeName(field.FieldType)} {GetVariableNameFrom(field.Name)}");

            return string.Join(",", parametrs);

        }






        public static string GetVariableNameFrom(string name) => char.ToLowerInvariant(name[0]) + name.Substring(1);





        private static bool HasSingleField(Type type, out FieldInfo field)
        {
           FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);//Получение массива о информации о его полях

            if (fields.Length != 1)
            {

                field = null;
                return false;

            }

            field = fields[0]; 
            return true;

        }


        private static string RemoveSuffixIsExist(string str, string suffix)
        {
            if (str.EndsWith(suffix))
            {

                return str.Substring(0,str.Length - suffix.Length);
            }

            return str;
        }


        private static IEnumerable<Type> GetComponentTypesFrom(Assembly assembly)
        {
            return assembly
                .GetTypes()//возвращает полный массив типов данной сборки;
                .Where(type => type.IsInterface == false
                    && type.IsAbstract == false
                    && typeof(IEntityComponent).IsAssignableFrom(type));
        }

        public static string GetValidTypeName(Type type)
        {
            Debug.Log($"Processing type: {type.FullName}");
            
            // Специальная обработка ValueTuple через строковые операции
            string typeFullName = type.FullName ?? "";
            if (typeFullName.Contains("ValueTuple") && typeFullName.Contains("Single"))
            {
                Debug.Log("Found ValueTuple - replacing with global:: version");
                return typeFullName.Replace("System.ValueTuple", "global::System.ValueTuple").Replace("System.Single", "float");
            }
            
            if (type.IsGenericType)
            {
                StringBuilder sb = new StringBuilder();

                string fullTypeName = type.GetGenericTypeDefinition().FullName;
                var backtickIndex = fullTypeName.IndexOf('`');

                if (backtickIndex >= 0)
                    fullTypeName = fullTypeName.Substring(0, backtickIndex);

                // Добавляем global:: для System типов
                if (fullTypeName != null && fullTypeName.StartsWith("System."))
                    fullTypeName = "global::" + fullTypeName;

                sb.Append(fullTypeName);
                sb.Append("<");

                Type[] genericArgs = type.GetGenericArguments();

                for (int i = 0; i < genericArgs.Length; i++)
                {
                    if (i > 0)
                        sb.Append(", ");
                    
                    sb.Append(GetValidTypeName(genericArgs[i]));
                }

                sb.Append(">");
                return sb.ToString();
            }
            else
            {
                 // Используем алиасы для примитивных типов
                if (type == typeof(float)) return "float";
                if (type == typeof(int)) return "int";
                if (type == typeof(bool)) return "bool";
                if (type == typeof(string)) return "string";
                if (type == typeof(double)) return "double";
                
                // Обработка System типов с global:: префиксом
                string typeName = type.FullName ?? "";
                if (typeName.StartsWith("System."))
                {
                    return "global::" + typeName;
                }
                
                return type.FullName;
            }
        }


    }
}
