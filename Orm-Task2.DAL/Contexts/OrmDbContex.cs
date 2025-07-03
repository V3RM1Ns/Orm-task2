using Microsoft.EntityFrameworkCore;
using Orm_Task2.Core.Entities;
using Orm_Task2.DAL.Configurations;

namespace Orm_Task2.DAL.Contexts;

public class OrmDbContex:DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=OrmDb;User Id=sa;Password=Hebib123!;Encrypt=False;");
        base.OnConfiguring(optionsBuilder);
}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}