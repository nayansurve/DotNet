using System;

public class VowelsAndConsonent
{
    public static void Main(string [] args)
    {
        Console.WriteLine("Enter A String = ");
        string str=Console.ReadLine().ToLower();

         int Vowels=0;
         int consonent=0;
        

        foreach(char ch in str)
        {
            if(ch >='a' && ch<='z')
            {
                if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u')
                {
                    Vowels++;
                }
                else
                {
                    consonent++;
                }
            }
        }
        Console.WriteLine("Vovels Count ="+Vowels);
         Console.WriteLine("Consonent Count ="+consonent);
    }
}