using Orm_Task2.BL.Dtos.StudentDto;
using Orm_Task2.BL.Profiles;
using Orm_Task2.BL.Services.Interfaces;
using Orm_Task2.Core.Entities;
using Orm_Task2.DAL.Contexts;

namespace Orm_Task2.BL.Services.Concretes;

public class StudentService:IStudentService
{
    private readonly OrmDbContex _context;
    public void CreateStudent(StudentCreateDto studentdto)
    {
       Student student=StudentProfile.StudentCreateToStudent(studentdto);
        _context.Students.Add(student);
        _context.SaveChanges();
    }

    public List<StudentReturnDto> GetAllStudents()
    {
        List<Student> students = _context.Students.ToList();
        List<StudentReturnDto> returnDtos = students
            .Select(s => StudentProfile.StudentToStudentReturnDto(s))
            .ToList();
        return returnDtos;
    }
    public StudentService()
    {
        _context = new OrmDbContex();
    }
    
}