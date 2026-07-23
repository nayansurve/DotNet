using System;
using System.Threading.Tasks;
using CalculatorDemo;
namespace DelegatePractice
{
    // Custom Delegate
    delegate void CalDelegate(int x, int y);

    class Program
    {
        static async Task Main(string[] args)
        {
            Calculator cal = new Calculator();

            Console.WriteLine("===== Delegate Chaining =====");

            CalDelegate del = cal.Add;
            del += cal.Sub;
            del += cal.Mul;

            del(20, 10);

            Console.WriteLine();

            Console.WriteLine("===== Async Delegate =====");

            Func<string, Task<string>> asyncDel = cal.AsyncMessage;

            string result = await asyncDel("transflower");

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("===== Anonymous Method using Action =====");

            Action<string> greet = delegate (string name)
            {
                Console.WriteLine($"Welcome {name}");
            };

            greet("Nayan");
        }
    }
}