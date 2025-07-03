using Orm_Task2.Core.Enums;

namespace Orm_Task2.Core.Entities;

public class Student:BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public StudentStatus Status { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }
}