using EFCorePractice.Models;
using EFCorePractice.DbContexts;
public class Program
{
    public static void Main(string [] args)
    {
       // string connectionString="Server=localhost;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";
     using (var context = new StudentDbContext())
    {
    Console.Write("How many students do you want to add? ");
    int count = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= count; i++)
    {
        Console.WriteLine($"\nEnter details for Student {i}");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Course: ");
        string course = Console.ReadLine();

        Student student = new Student
        {
            Name = name,
            Age = age,
            Course = course
        };

        context.Studentss.Add(student);
    }
     context.SaveChanges();

    Console.WriteLine("\nAll students added successfully!");

}
    }
   
}
