using System;
using System.Collections;
using System.IO;

namespace Assets._Project.Develop.Runtime.Utilities.DataManagement.DataRepository
{
    public class LocalFileRepository : IDataRepository
    {
        private readonly string _folderPath;
        private readonly string _saveFileExtension;

        public LocalFileRepository(string folderPath, string saveFileExtension)
        {
            _folderPath = folderPath;
            _saveFileExtension = saveFileExtension;
        }

        public IEnumerator Exist(string key, Action<bool> onExistResult)
        {
            bool exist = File.Exists(FullPathFor(key));

            onExistResult?.Invoke(exist);

            yield break;
        }


        public IEnumerator Read(string key, Action<string> onRead)
        {
            string text = File.ReadAllText(FullPathFor(key));

            onRead?.Invoke(text);

            yield break;
        }

        public IEnumerator Remove(string key)
        {
            File.Delete(FullPathFor(key));

            yield break;
        }

        public IEnumerator Write(string key, string serializedData)
        {
           File.WriteAllText(FullPathFor(key), serializedData);

            yield break;
        }
        private string FullPathFor(string key)
            =>Path.Combine(_folderPath, key) + " . " + _saveFileExtension;
    }
}
