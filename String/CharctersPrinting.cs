using System;

public class Simple
{
    public static void Main(string [] args)
    {
        Console.WriteLine("Enter a String =");
        string str=Console.ReadLine();


        string UpperCase="";
        string LowerCase="";
        string Digits="";
        string SpecialChar="";

       foreach(char ch in str)
        {
            if(ch >= 'a' && ch<='z')
            {
                LowerCase+=ch;
            }
            else if(ch >='0' && ch <='9')
            {
                Digits+=ch;
            }
            else if(ch >='A' && ch <='Z')
            {
                UpperCase+=ch;
            }
            else
            {
                SpecialChar+=ch;
            }
        }
        Console.WriteLine($"Lowercase  = {LowerCase}");
        Console.WriteLine($"Digit  = {Digits}");
        Console.WriteLine($"upercase  = {UpperCase}");
          Console.WriteLine($"Special Character  = {SpecialChar}");
}
}