using System;

public class Simple
{
    public static void Main(string [] args)
    {
        Console.WriteLine("Enter a String =");
        string str=Console.ReadLine();


        int UpperCase=0;
        int LowerCase=0;
        int Digits=0;
        int SpecialChar=0;

       foreach(char ch in str)
        {
            if(ch >= 'a' && ch<='z')
            {
                LowerCase++;
            }
            else if(ch >='0' && ch <='9')
            {
                Digits++;
            }
            else if(ch >='A' && ch <='Z')
            {
                UpperCase++;
            }
            else
            {
                SpecialChar++;
            }
        }
        Console.WriteLine($"Lowercase Count = {LowerCase}");
        Console.WriteLine($"Digit Count = {Digits}");
        Console.WriteLine($"upercase Count = {UpperCase}");
          Console.WriteLine($"Special Character Count = {SpecialChar}");
}
}