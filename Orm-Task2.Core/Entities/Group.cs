namespace Orm_Task2.Core.Entities;

public class Group:AuditEntity
{
    public string No { get; set; }
    public int Limit { get; set; }
    public List<Student> Students { get; set; }
}