namespace AsynchronousDelegateDemo;

delegate string MyDelegate(string str);
public class Demo
{
   

         public  string ToUpper(string str)
 
    {
        Thread.Sleep(10000);
        return str.ToUpper();
    }
     
    
  

    
}