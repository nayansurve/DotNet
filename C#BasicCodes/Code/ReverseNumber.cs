using System;

public class ReverseNumber
{
    public static void Main(string [] args)
    {
        int n,n1,rev=0,rem=0;
        Console.WriteLine("Enter a Number");
        n=Convert.ToInt32(Console.ReadLine());

        while(n>0)
        {
            rem=n%10;
            rev=rev*10+rem;
            n=n/10;
        }
        Console.WriteLine($"{rev} ");
    }
}