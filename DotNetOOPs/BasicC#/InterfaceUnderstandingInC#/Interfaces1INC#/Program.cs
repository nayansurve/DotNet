using demo;

public class Program
{
    public static void Main(string [] args)
    {
        Team t=new Team();

        foreach(Player c in t)
        {
            Console.WriteLine($"{c.Name},{c.runs}");
        }
    }
}