using System;

public class Palindrome
{
    public static void Main(string [] args)
    {
        int n,n1,rem,rev=0;
        Console.WriteLine("Enter a Number");
        n=Convert.ToInt32(Console.ReadLine());
        n1=n;

        while(n>0)
        {
            rem=n%10;
            rev=rev*10+rem;
            n=n/10;

        }

        if(n1 == rev)
        {
            Console.WriteLine($"{n1} is a palindrome");
        }
        else
        {
            Console.WriteLine($"{n1} is not a palindrome");
        }
    }
}