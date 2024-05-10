using AutoGenerate.Models;
namespace AutoGenerate;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-DD hh:mm:ss}] [Success] Start");
            // new Generate().CreateDB();
            new Generate().CreateDB();
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-DD hh:mm:ss}] [Success] End");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}