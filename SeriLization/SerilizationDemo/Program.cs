using System.Text.Json;
using SerilizationDemo;

public class Program
{
    public static void Main(string [] args)
    {
        Employee e=new Employee();
        e.Id=101;
        e.Name="Nayan";


        // now here we need to convert object into json 

        string json=JsonSerializer.Serialize(e);

        //Now here we need to save the json into file 

        File.WriteAllText("e.json",json);

        Console.WriteLine("Employee Saved Suceessfully");

       
    }
}