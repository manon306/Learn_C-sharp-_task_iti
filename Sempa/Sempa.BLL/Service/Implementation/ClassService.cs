using AutoMapper;
using Sempa.BLL.Helper;
using Sempa.DAL.Repo.Implementation;

namespace Sempa.BLL.Service.Implementation
{
    public class ClassService : IClassService
    {
        private readonly IClassRepo classRepo;
        private readonly IMapper _mapper;

        public ClassService(IClassRepo classRepo, IMapper mapper)
        {
            this.classRepo = classRepo;
            _mapper = mapper;
        }
        public (bool, string?) Create(CreateVm user)
        {
            
            var newUser = new DAL.Entity.CLass(user.Name,user.Students);
            var result = classRepo.Create(newUser);
            if (result)
            {
                return (true, null);
            }
            return (false, "Failed to create user. :=(");
        }
        public (bool, List<GetVm>?, List<User>?, List<User>?, string?) GetAll()
        {
            var result = classRepo.GetAll();

            if (result != null && result.Any())
            {
                // مابنج الكلاسات للـ ViewModel
                var classes = _mapper.Map<List<GetVm>>(result);

                // الطلاب
                var students = result
                    .SelectMany(c => c.Students)
                    .Where(u => u.UserType == Sempa.DAL.Enum.UserType.Student)
                    .ToList();

                // المدرسين
                var teachers = result
                    .SelectMany(c => c.Students)
                    .Where(u => u.UserType == Sempa.DAL.Enum.UserType.Teacher)
                    .ToList();

                return (true, classes, students, teachers, null);
            }

            return (false, null, null, null, "Failed to Get All Classes :( ");
        }

    }
}
