using System;
using System.IO;
using System.Threading.Tasks;

public class Program
{
    static async Task ReadFileAsync()
    {
        Console.WriteLine("Reading File....");

        string[] data = await File.ReadAllLinesAsync("Student.txt");
         await Task.Delay(5000);
        Console.WriteLine("File Data :");

        foreach (string line in data)
        {
            Console.WriteLine(line);
        }
    }
    static async Task Main()
    {
        Console.WriteLine("Program Started");

        await ReadFileAsync();

        Console.WriteLine("Program Finished");
    }
}