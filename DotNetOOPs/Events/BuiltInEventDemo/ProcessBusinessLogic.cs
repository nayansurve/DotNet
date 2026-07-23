using System.Diagnostics;

namespace BuiltInDemo;

public class ProcessBusinessLogic
{
    public event EventHandler ProcessCompleted;

    public void StartProcess()
    {
        Console.WriteLine("Process Started");
        OnProcessCompleted(EventArgs.Empty);
    }

    protected virtual void OnProcessCompleted(EventArgs e)
    {
        ProcessCompleted?.Invoke(this,e);
    }
}