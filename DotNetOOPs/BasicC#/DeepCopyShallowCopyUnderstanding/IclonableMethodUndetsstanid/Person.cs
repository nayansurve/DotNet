namespace Demo;

public class Person :ICloneable
{
    public string Name {get; set;}

    public int Age {get;set;}

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}