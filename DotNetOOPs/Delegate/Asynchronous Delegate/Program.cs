using System.Runtime.CompilerServices;
using AsynchronousDelegateDemo;

public class Program
{
    public static async Task Main(string [] args)
    {
        {
             Demo d=new Demo();

        MyDelegate del=d.ToUpper;

        Console.WriteLine("Starting....!!!!!!");

        string result=await  ToUpper("transflower");
        Console.WriteLine(result);

        Console.WriteLine("Finished");


        }

        static async Task<string> ToUpper(string str)
        {
            await Task.Delay(3000);

            return  str.ToUpper();
        }
       
        // IAsyncResult result=del.BeginInvoke("Transflower",null,null);

        // Console.WriteLine("Doing Other Work");

        // string output=del.EndInvoke(result);

        // Console.WriteLine(output);

        // here the BeginInvke() and EndInvoke() Methods are supported in old dotnet framework

        // so here this are the old methods so instead of this we use async and await with Task


    }
}