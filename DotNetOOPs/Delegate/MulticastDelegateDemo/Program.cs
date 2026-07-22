using MulticastDemo;

public class Program
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        Manager m = new Manager();

        MulticastDeleagte del = emp.Hello;

        del = del + emp.WelCome;

        del = del + emp.GoodBye;

        MulticastDeleagte del1 = m.Display;

        del();

        del1();
    }
}