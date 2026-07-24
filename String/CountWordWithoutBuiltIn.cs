using System;

public class WordCount
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string str = Console.ReadLine();

        int count = 0;
        bool inWord = false;

        foreach (char ch in str)
        {
            if (ch != ' ')
            {
                if (!inWord)
                {
                    count++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }

        Console.WriteLine("Number of words = " + count);
    }
}