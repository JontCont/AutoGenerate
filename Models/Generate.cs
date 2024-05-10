using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using AutoGenerate.Models;
namespace AutoGenerate.Models;
public class Generate
{
    public Generate()
    {
    }

    public void CreateDB()
    {
        // 建立 DbContextOptions
        var options = new DbContextOptionsBuilder<YourDbContext>()
            .UseSqlServer("server=CONTE-MA-PC\\SQLEXPRESS;uid=sa;pwd=root;Trusted_Connection=no;database=TestDB;Encrypt=false;")
            .Options;
        var ctt = new YourDbContext(options);
        if (!ctt.Database.EnsureCreated())
        {
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-DD hh:mm:ss}] [Run] Update Table or Insert Table ");
            ctt.Database.Migrate();
        }
        Console.WriteLine($"[{DateTime.Now:yyyy-MM-DD hh:mm:ss}] [Success] Done");
    }

    public void UpdateDB()
    {
        // 建立 DbContextOptions
        var options = new DbContextOptionsBuilder<YourDbContext>()
            .UseSqlServer("server=CONTE-MA-PC\\SQLEXPRESS;uid=sa;pwd=root;Trusted_Connection=no;database=TestDB;Encrypt=false;")
            .Options;
        var ctt = new YourDbContext(options);
        Console.WriteLine($"[{DateTime.Now:yyyy-MM-DD hh:mm:ss}] [Run] Update Table or Insert Table ");
        ctt.Database.Migrate();
        Console.WriteLine($"[{DateTime.Now:yyyy-MM-DD hh:mm:ss}] [Success] Done");
    }
}