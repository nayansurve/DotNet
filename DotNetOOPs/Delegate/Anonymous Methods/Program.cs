//An Anonymous Method is an unnamed method used when we don't want to create a separate method
delegate string MyDelegate(string str);
public class Program
{
    public static void Main(string [] args)
    {
        MyDelegate del=delegate(string str)
        {
           return str.ToUpper();
        };

        Console.WriteLine(del("TransFlower"));
        
    }
}