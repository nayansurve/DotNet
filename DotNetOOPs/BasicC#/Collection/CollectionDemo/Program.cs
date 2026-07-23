using System.Security.Cryptography.X509Certificates;
using WorldCup;

public class Prorgam
{
    public static void Main(string [] args)
    {
        Team argentina=new Team();
        Team portugalTeam=new Team();

         string playername=argentina[0].Name;
        
          Console.WriteLine("Player Name = "+ playername);
          Console.WriteLine();

         argentina.DisplayPlayers();
  


  
    


         
    }
}