using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter some text: ");
                string input = Console.ReadLine();
                try
                {
                    Console.WriteLine($"first character: '{input[0]}'");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Wrong input: ");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again.");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

        }
    }
}
//using (resource) { } // it is like try - finally
//finaly may not be called when 3 critical exceptions raised: stackoverflow, memory exceed, ...
//catch (Exception ex) when ex.Message == null //extra check of exception