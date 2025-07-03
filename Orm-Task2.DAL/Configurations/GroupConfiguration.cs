using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orm_Task2.Core.Entities;
using Orm_Task2.Core.Enums;

namespace Orm_Task2.DAL.Configurations;
public class GroupConfiguration:IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.Property(g=>g.No).IsRequired();
        builder.Property(g=>g.Limit).IsRequired();
        builder.HasIndex(g=>g.No).IsUnique();
        builder.HasData(new Group { Id = 1, No = "PB305", Limit = 10 });
    }
}