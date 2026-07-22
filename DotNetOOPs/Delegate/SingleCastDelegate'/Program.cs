using SingleDelegateDemo;

public class Program
{
    public static void Main(string [] args)
    {
        ReverseStringDemo revstr=new ReverseStringDemo();

        strDelegate del=revstr.RevString;

       string Result= del("TransFlower");

        Console.WriteLine("After Reversing String Becomes= "+ Result);
    }
}