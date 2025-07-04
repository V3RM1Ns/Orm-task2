
using Orm_Task2.DAL.Repositories.Concretes;
using Orm_Task2.DAL.Repositories.Interfaces;

namespace Orm_Task2.BL.Services.Concretes;

public class StudentService:IStudentService
{
   private readonly IRepository<Student> _repository;
    public void CreateStudent(StudentCreateDto studentdto)
    {
       Student student=StudentProfile.StudentCreateToStudent(studentdto);
      _repository.Add(student);
      
    }

    public void Delete(Student student)
    {
        _repository.Delete(student);
    }

    public Student GetById(int id)
    {
       return _repository.GetById(id);
    }

    public void Update(Student student)
    {
        _repository.Update(student);
    }

    public StudentService()
    {
        _repository = new Repository<Student>();
    }
    
}