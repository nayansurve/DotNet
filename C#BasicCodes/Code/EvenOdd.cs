using System;

public class EvenOdd
{
    public static void Main(string []args)
    {
        int n;
        Console.WriteLine("Enter a Number = ");
        n=Convert.ToInt32(Console.ReadLine());

        if(n % 2==0)
        {
            Console.WriteLine($"{n} is a even number");
        }
        else
        {
            Console.WriteLine($"{n} is odd number");
        }
        
    }
}