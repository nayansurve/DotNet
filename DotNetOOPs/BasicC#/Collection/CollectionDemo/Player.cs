namespace WorldCup;

public class Player
{

   public int PlayerId {get;set;}// here we declare on private varibale
   public string Name{get;set;}

public int JerseyNumber{get;set;}

public string Position{get;set;}

public int Age{get;set;}

public string Nationality {get;set;}

public decimal Salary {get;set;}

   public Player(int playerid,string name,
   int jerseynumber,string position,int age, 
   string nationality,decimal salary)   // here we write the constructor
    {
       this.PlayerId=playerid;
       this.Name=name;
       this.JerseyNumber=jerseynumber;
       this.Position=position;
       this.Age=age;
       this.Nationality=nationality;
       this.Salary=salary; 
    }

    //Property
    // public int PlayerId
    // {
    //     get
    //     {
    //         return this.playerId;
    //     }
    //     set
    //     {
    //     this.playerId=value;
    //     }
    // }

    //now here we can also use auto property we did not 
    // write the complete get and set method implementatio

}