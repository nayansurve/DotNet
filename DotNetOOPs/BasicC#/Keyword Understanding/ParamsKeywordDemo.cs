namespace ParamKeywordDemo;

public class Demo
{
    public void PrintNames(params string [] names)
    {
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
    }
}