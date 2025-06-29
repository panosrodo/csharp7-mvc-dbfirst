using SchoolApp.Data;

namespace SchoolApp.Repositories
{
    public interface IUnitOfWork
    {
        // UserRepository ToDO
        TeacherRepository TeacherRepository { get; }
        StudentRepository StudentRepository { get; }
        CourseRepository CourseRepository { get; }

        Task<bool> SaveAsync();
    }
}
