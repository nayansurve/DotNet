using System;

public class WordCount
{
    public static void Main(string[] args)
    {
        string str;
        Console.WriteLine("Enter a String =");
        str=Console.ReadLine();

       string[] words=str.Split(' ');
       Console.WriteLine("Number of Words" +words.Length);
       
    }
}