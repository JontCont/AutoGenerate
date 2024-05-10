using Microsoft.EntityFrameworkCore;
namespace AutoGenerate.Models;
public class YourDbContext : DbContext
{
    public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
    {
    }
    
    public DbSet<YourEntity> YourEntities { get; set; }
    public DbSet<ExamEntity> ExamEntity { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // 在這裡進行資料模型的配置
        modelBuilder.Entity<YourEntity>()
            .HasKey(e => e.Id);

        modelBuilder.Entity<ExamEntity>()
            .HasKey(e => e.Id);
    }
}
