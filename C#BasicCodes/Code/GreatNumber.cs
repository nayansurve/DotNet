using System;
using System.Security.Cryptography.X509Certificates;

public class GreatNumber
{
    public static void Main(string [] args)
    {
        int n,n1,n2,n3,n4;

        Console.WriteLine("Enter a Number = ");
        n=Convert.ToInt32(Console.ReadLine());

    
        Console.Write("Enter Second Number : ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Third Number : ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Fourth Number : ");
        n3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Fifth Number : ");
        n4 = Convert.ToInt32(Console.ReadLine());

        if(n>n1 && n>n2 && n>n3 && n>n4)
        {
            Console.WriteLine($"{n} is the Greater Number");
        }
        else if(n1>n && n1>n2 && n1>n3 && n1 > n4)
        {
            Console.WriteLine($"{n1} is a greater number");
        }
         else if(n2>n && n2>n1 && n2>n3 && n2>n4 )
        {
            Console.WriteLine($"{n2} is a greater number");
        }
         else if(n3>n && n3>n1 && n3>n2 && n3>n4)
         
        {
            Console.WriteLine($"{n3} is a greater number");
        }
        else
        {
            Console.WriteLine($"{n4} is greater number");
        }
    }
}