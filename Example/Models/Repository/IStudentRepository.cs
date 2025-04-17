using Example.Models.Domain;
using Example.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Example.Models.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll(string? searchString, string? type);
        VMStudent GetStudentsById(int id);
        void UpdateStudentById(int id, VMStudent model);
        void AddStudent(VMStudent model);
        void DeleteStudentById(int id);
    }
}
