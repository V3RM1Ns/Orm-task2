namespace Orm_Task2.Core.Entities;

public class AuditEntity : BaseEntity
{
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime Updated { get; set; }
    public bool IsDeleted { get; set; }
}