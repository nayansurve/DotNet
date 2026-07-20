using simpleNullableClass;

public class Program
{
    public static void Main(string [] args)
    {
        DataReader dr=new DataReader();

        int? i=dr.GetIntValue();
      
            if(i.HasValue)
            {
                Console.WriteLine($"Value Of I is : {0}",i.Value);
            }
            else
            {
                Console.WriteLine($"value of i is undefined");
            }
       
           bool? b=dr.GetBoolValue();
           if(b.HasValue)
        {
            Console.WriteLine("value of b is"+b.Value);
        }
        else
        {
            Console.WriteLine("Value of b is undefined");
        }
       

           int? myData=dr.GetIntValue() ??100;
           Console.WriteLine("value of my data is "+myData.Value);
    }
}