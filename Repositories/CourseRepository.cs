﻿using Microsoft.EntityFrameworkCore;
using SchoolApp.Data;

namespace SchoolApp.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(Mvc7DbContext context)
            : base(context)
        {
        }

        public async Task<List<Student>> GetCoursesStudentsAsync(int id)
        {
            return await context.Courses
                .Where(c => c.Id == id)
                .SelectMany(c => c.Students)
                .ToListAsync();
        }

        public async Task<Teacher?> GetCourseTeacherAsync(int id)
        {
            var course = await context.Courses
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();

            return course?.Teacher;
        }
    }
}