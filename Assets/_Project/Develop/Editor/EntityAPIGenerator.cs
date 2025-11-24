using System.IO;
using UnityEngine;
using System.Text;
using UnityEditor;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using System.Reflection;
using System;
using System.Linq;
using System.Collections.Generic;



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
                string modifiedComponentName = componentName + "С";

                //свойство для получения компонента
                sb.AppendLine($"\t\tpublic {fullTypeName} {modifiedComponentName} => GetComponent<{fullTypeName}>();");
                sb.AppendLine();
            }

            sb.AppendLine("\t}");

            sb.AppendLine("}");

            File.WriteAllText(OutputPath, sb.ToString());

            AssetDatabase.Refresh();
            AssetDatabase.SaveAssets();

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




    }
}
