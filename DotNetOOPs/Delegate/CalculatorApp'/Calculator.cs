namespace CalculatorDemo;

delegate void CalDelegate();
public class Calculator
{
    //Define a Calculator class with Add, Subtract, and Multiply methods

    public void Add(int x,int y)
    {
        Console.WriteLine("Add Method Call ");
        Console.WriteLine($"{x+y}");

    }

    public void Sub(int x,int y)
    {
        Console.WriteLine("Sub Method Called");
        Console.WriteLine($"{x-y}");
    }

    public void Mul(int x,int y)
    {
        Console.WriteLine("Mul Method Called");
        Console.WriteLine($"{x*y}");

    }
     public async Task<string> AsyncMessage(string message)
        {
            await Task.Delay(3000);
            return message.ToUpper();
        }

}