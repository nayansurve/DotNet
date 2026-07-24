using System;

public class VowelsConsonentPrint
{
    public static void Main(string[] args)
    {
        string str;
        Console.WriteLine("Enter A string =");
        str=Console.ReadLine().ToLower();

        string vowels="";
        string Consonent="";

        foreach(char ch in str)
        {
            if(ch >= 'a' && ch<='z' )
            {
                if(ch == 'a' || ch=='i' || ch=='o' || ch=='u' || ch=='e')
                {
                    vowels=vowels+ch;
                }
                else
                {
                    Consonent=Consonent+ch;
                }
            }
        }
        Console.WriteLine("Vowels are = " + vowels);
        Console.WriteLine("Consonent are = "+ Consonent);

    }
}