namespace Assets._Project.Develop.Runtime.Utilities.DataManagement.DatapProvider
{
    public interface IDataReader<TData> where TData : ISaveData 
    {
        void ReadFrom(TData data);

    }


}
