using Orm_Task2.BL.Dtos.StudentDto;
using Orm_Task2.Core.Entities;

namespace Orm_Task2.BL.Profiles;

public class StudentProfile
{
    public static Student StudentCreateToStudent(StudentCreateDto studentdto)
    {
        return new Student
        {
            Name = studentdto.Name,
            Surname = studentdto.Surname,
            Email = studentdto.Email,
            GroupId = studentdto.GroupId,
        };
    }

    public static StudentReturnDto StudentToStudentReturnDto(Student student)
    {
        return new StudentReturnDto
        {
            Name = student.Name,
            Surname = student.Surname,
            Email = student.Email,
            GroupId = student.GroupId,
        };
    }
}