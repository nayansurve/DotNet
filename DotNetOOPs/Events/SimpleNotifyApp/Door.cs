using System;
namespace EventDemo;

public delegate void NotifyDelegate();
public class Door{

    
public event NotifyDelegate DoorOpend;

   public void OpenDoor()
    {

        Console.WriteLine("Door Opend");
        DoorOpend?.Invoke();
    }
}