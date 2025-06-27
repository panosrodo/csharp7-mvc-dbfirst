using SchoolApp.Data;

namespace SchoolApp.Repositories
{
    public interface ICourseRepository
    {
        Task<List<Student>> GetCoursesStudentsAsync(int id);
        Task<Teacher?> GetCourseTeacherAsync(int id);
    }
}
