using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    public class FileHelper<T> where T : new()
    {
        private string _filePath;

        public FileHelper(string filePath)
        {
            _filePath = filePath;
        }
        public void SerializeToFile(T employees)
        {
            var jsonData = JsonConvert.SerializeObject(employees, Formatting.Indented);
            File.WriteAllText(_filePath, jsonData);

        }

        public T DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new T();
            }
            var jsonData = File.ReadAllText(_filePath);
            var employees = JsonConvert.DeserializeObject<T>(jsonData);
            return employees;
        }
    }
}
