using EFCorePractice.Models;
using Microsoft.EntityFrameworkCore;
namespace EFCorePractice.DbContexts;
public class StudentDbContext : DbContext
{
    public DbSet<Student> Studentss { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost;Database=StudentNayanDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}



