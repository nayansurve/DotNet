using System;

public class Program
{
    
    static async Task<string> FetchDataAsync()
    {
        Console.WriteLine("Fetching data from server....");
        await Task.Delay(2000);
        return "Data Fetched Successfully";
    }

    static async Task ProcessDataAsync()
    {
        try
        {
            string data=await FetchDataAsync();
            Console.WriteLine(data);
            Console.WriteLine("Processing the data...");

        }
        catch(Exception e)
        {
            Console.WriteLine("Something Goes Wrong .!!!"+e.Message);
        }
    }
    static async Task Main(string [] args)
    {
        Console.WriteLine("Process Started ...!!!");  // main first return this line 
        await ProcessDataAsync();
        Console.WriteLine("Processing Completed ...!!");
    }
}