using System.Runtime.Intrinsics.X86;
using BuiltInDemo;

public class Program
{
    static void B1_ProcessCompleted(object sender,EventArgs e)
    {
        Console.WriteLine("Process Completed");
    }
    public static void Main(string [] args)
    {
        ProcessBusinessLogic p=new ProcessBusinessLogic();
        p.ProcessCompleted+=B1_ProcessCompleted;
        p.StartProcess();
    }
}