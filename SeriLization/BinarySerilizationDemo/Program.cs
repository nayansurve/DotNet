using System;
using BinarySerilizationDemo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Program
{
    public static void Main(string [] args)
    {

        Employee emp=new Employee();
        emp.Id=101;
        emp.Name="Naina";

        BinaryFormatter bf=new BinaryFormatter();
        
    }
}