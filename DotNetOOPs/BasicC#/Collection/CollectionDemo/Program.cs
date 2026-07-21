using WorldCup;

public class Prorgam
{
    public static void Main(string [] args)
    {
        Team argentina=new Team();

        string playername=argentina[0].Name;
        Console.WriteLine("Player Name = "+ playername);
         argentina.DisplayPlayers();

    }
}