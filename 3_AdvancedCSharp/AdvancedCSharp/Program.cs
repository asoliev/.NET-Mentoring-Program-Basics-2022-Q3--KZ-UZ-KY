// See https://aka.ms/new-console-template for more information
using AdvancedCSharp;

var fsv = new FileSystemVisitor(@"C:\src\dot_net_mentoring_basics\AdvancedCSharp");
var filter = "";
var fileTree = fsv.GetFileTree(filter);
foreach (string item in fileTree)
{
    Console.WriteLine(item);
}
Console.ReadKey();
Console.ReadKey();