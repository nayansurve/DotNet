using System;

public class PalindromeString
{
    public static void Main(string [] args)
    {
        string str;
        Console.WriteLine("Enter The String = ");
        str=Console.ReadLine();
        string rev="";
        string str1=str;

        for(int i=str.Length-1;i>=0;i--)
        {
            rev=rev+str[i];
        }
        Console.WriteLine($"reverse string is {rev}");

        if(str1==rev)
        {
            Console.WriteLine($"{str1} is palindrome");
        }
        else
        {
            Console.WriteLine($"{str1} is not palindrome");
        }
    }
}