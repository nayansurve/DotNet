using System;

public class LeapYear
{
    public static void Main(string []args)
    {
        int n;
        Console.WriteLine("Enter a Year = ");
        n=Convert.ToInt32(Console.ReadLine());

        if(n % 4 == 0)
        {
            Console.WriteLine($"{n}  is the Leap year");
        }
        else
        {
            Console.WriteLine($"{n} is not a leap year");
        }
    }
}