using SchoolApp.Data;
using SchoolApp.DTO;

namespace SchoolApp.Services
{
    public interface ITeacherService
    {
        Task SignUpUserAsync(TeacherSignupDTO request);
        Task<List<User>> GetAllUsersTeachersAsycn();
        Task<List<User>> GetAllUsersTeachersAsycn(int pageNumber, int pageSize);
        Task<int> GetTeacherCountAsycn();
        Task<User?> GetTeacherByUsernameAsycn(string username);
    }
}
