using AutoMapper;
using SchoolApp.Repositories;

namespace SchoolApp.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UserService> _uLogger;
        private readonly ILogger<TeacherService> _tLogger;
        private readonly ILogger<StudentService> _sLogger;

        public ApplicationService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UserService> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _uLogger = logger;
        }

        public ApplicationService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<TeacherService> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _tLogger = logger;
        }

        public ApplicationService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<StudentService> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _sLogger = logger;
        }


        public UserService UserService => new(_unitOfWork, _mapper, _uLogger);
        public TeacherService TeacherService => new(_unitOfWork, _mapper, _tLogger);
        public StudentService StudentService => new(_unitOfWork, _mapper, _sLogger);
    }
}
