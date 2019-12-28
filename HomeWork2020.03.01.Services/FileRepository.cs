using HomeWork2020._03._01.AbstractModels;
using System.IO;

namespace HomeWork2020._03._01.Services
{
    public class FileRepository<T> : IRepository<T> where T : class
    {
        private readonly string _filePath;
        public FileRepository(string filePath)
        {
            _filePath = filePath;
            
            if(!File.Exists(_filePath))
            {
                using (File.Create(_filePath)) { }
            }
        }

        public void Add(T item)
        {
            using(var stream = new StreamWriter(_filePath))
            {
                stream.WriteLine(item);
            }
        }

        public void Delete(T item)
        {
            string result = File.ReadAllText(_filePath);
            result.Replace(item.ToString(), "");
            File.WriteAllText(_filePath, result);
        }

        public string GetAll()
        {
            return File.ReadAllText(_filePath);
        }
    }
}
