namespace SingleDelegateDemo;


delegate string strDelegate(string str);
public class ReverseStringDemo
{

    public string RevString(string str)
    {
        Console.WriteLine("Original String = "+ str);
        char [] ch= str.ToCharArray();
        Array.Reverse(ch);
        return new string(ch);

    
}
}