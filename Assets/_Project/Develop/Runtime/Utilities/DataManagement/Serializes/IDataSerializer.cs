namespace Assets._Project.Develop.Runtime.Utilities.DataManagement.Serializes
{
    public interface IDataSerializer 
    {
        string Serialize<TData>(TData data);
        TData Deserialize<TData>(string serializedData);

    }

}