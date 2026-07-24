using System;

public class Simple
{
    public static void Main (string[] args)
    {
        string str;
        Console.WriteLine("Enter a String = ");
        str=Console.ReadLine().ToLower();

        int count=0;

         foreach(Char ch in str)
        {
            if(ch >='a' && ch<='z')
            {
                count ++;
            }
        }
        Console.WriteLine("Words Count =" +count);
    }
}