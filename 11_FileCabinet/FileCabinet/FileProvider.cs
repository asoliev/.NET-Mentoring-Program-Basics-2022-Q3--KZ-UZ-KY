using FileCabinet.Models;
using System.Text.Json;

namespace FileCabinet
{
    public class FileProvider : IProvider
    {
        public BaseDocument Read(int id)
        {
            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            var files = directory
                .GetFiles("*.json")
                .Where(file => file.Name.Contains("_"))
                .ToList();

            var file_filtered = files
                .Where(file => file.Name.Contains(id.ToString()))
                .First();

            var jsonString = File.ReadAllText(file_filtered.FullName);
            var type = docTypes.First(t => t.Name.Split('_')[0].Equals(t.Name));
            var document = JsonSerializer.Deserialize(jsonString, type);
            return document;
        }

        public void Write(BaseDocument document)
        {
            var json = JsonSerializer.Serialize(document, document.GetType());
            var path = $"{document.GetType().Name}_{document.Id}.json";
            File.WriteAllText(path, json);
        }
    }
}