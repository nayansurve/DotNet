using System;
using System.ComponentModel.DataAnnotations;

public class StringLength
{
    public static void Main(string [] args)
    {
        // without using Length
        string str;
        Console.WriteLine("Enter a String");
        str=Console.ReadLine();
       
          
        int count=0;

        foreach(char ch in str)
        {
            count++;
        }
        Console.WriteLine("Length Of the String is ="+count);
    }

        
}
//using for loop and with length
//  int count=0;
//          for(int i=0;i<str.Length;i++)
//         {
//             count++;
//         }
//            Console.WriteLine(count);
