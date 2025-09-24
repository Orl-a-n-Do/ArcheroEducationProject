namespace Assets._Project.Develop.Runtime.Utilities.DataManagement.DatapProvider
{
    public interface IDataWriter<TData> where TData : ISaveData
    {
        void WriteTo(TData data);

    }


}
