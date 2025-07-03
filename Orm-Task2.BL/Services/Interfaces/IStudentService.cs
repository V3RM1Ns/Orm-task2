using Orm_Task2.BL.Dtos.StudentDto;

namespace Orm_Task2.BL.Services.Interfaces;

public interface IStudentService
{
    public void CreateStudent(StudentCreateDto student);
    public List<StudentReturnDto> GetAllStudents();
}