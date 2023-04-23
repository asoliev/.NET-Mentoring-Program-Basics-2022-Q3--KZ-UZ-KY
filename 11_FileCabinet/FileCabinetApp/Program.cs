using FileCabinet;
using FileCabinetApp;
using FileCabinet.Models;

var repo = new DocumentService(new FileProvider());
repo.Write(new List<BaseDocument>
{
    TestData.Patent,
    TestData.Book,
    TestData.LocalizedBook,
    TestData.Magazine,
});
for (int i = 1; i <= DocumentService.GetDocumentTypes().Count(); i++)
{
    var byId = repo.GetById(i);
    Console.WriteLine(byId.GetType());
    Console.WriteLine(byId);
}
Console.ReadKey();