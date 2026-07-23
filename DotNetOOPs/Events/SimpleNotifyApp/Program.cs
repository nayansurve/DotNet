using EventDemo;

public class Program
{
    static void RingBell()
        {
            Console.WriteLine("Someone Entered");
        }
    public static void Main(string []args)
    {
        
        Door d=new Door();
        d.DoorOpend+=RingBell;
        d.OpenDoor();
    }
}