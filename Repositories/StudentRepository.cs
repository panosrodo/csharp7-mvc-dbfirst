using Microsoft.EntityFrameworkCore;
using SchoolApp.core.enums;
using SchoolApp.Data;

namespace SchoolApp.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(Mvc7DbContext context)
            : base(context)
        {
        }
        public async Task<Student?> GetByAM(string? am)
        {
            return await context.Students
                .Where(s => s.Am == am)
                .SingleOrDefaultAsync();
        }
        public async Task<List<Course>> GetStudentCoursesAsync(int id)
        {
            return await context.Students
                .Where(s => s.Id == id)
                .SelectMany(s => s.Courses)
                .ToListAsync();
        }
        public async Task<List<User>> GetAllUserStudentsAsync()
        {
            return await context.Users
                .Where(u => u.UserRole == UserRole.Student)
                .Include(u => u.Student)
                .ToListAsync();
        }

    }
}