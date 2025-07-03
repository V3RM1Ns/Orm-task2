using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orm_Task2.Core.Entities;
using Orm_Task2.Core.Enums;

namespace Orm_Task2.DAL.Configurations;
public class StudentConfiguration:IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasOne(s => s.Group)
            .WithMany(g=>g.Students)
            .HasForeignKey(s=>s.GroupId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Property(s=>s.Name).IsRequired();
        builder.Property(s=>s.Surname).IsRequired();
        builder.Property(s=>s.Email).IsRequired();
        builder.Property(s=>s.Status).HasDefaultValue(StudentStatus.Inactive);
        builder.HasIndex(s=>s.Email).IsUnique();
    }
}
