using Orm_Task2.BL.Dtos.StudentDto;

namespace Orm_Task2.BL.Services.Interfaces;

public interface IStudentService
{
    public void CreateStudent(StudentCreateDto student);
    public void Delete(Student student);
    public Student GetById(int id);
    public void Update(Student student);
}