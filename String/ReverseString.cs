using System;

public class ReverseString
{
    public static void Main(string [] args)
    {
        string str;
        Console.WriteLine("Enter A String = ");
        str=Console.ReadLine();
        string rev="";
        string str1=str;

        for(int i =str.Length-1;i>=0;i--)
        {
            rev=rev+str[i];
        }

        Console.WriteLine($"Reverse String = {rev}");
    }
}