using System.Collections;
using System.Security;
namespace demo;

public class Team : IEnumerable
{
    private Player [] players;


    public Team()
    {
        players =new Player[3];
        players[0]=new Player("Rohit",6000);
        players[1]=new Player("Virat",89);
        players[2]=new Player("Sachin",70);
    }

    public IEnumerator GetEnumerator()
    {
        return players.GetEnumerator();
    }
}