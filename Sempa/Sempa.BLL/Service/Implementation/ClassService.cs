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

            var newUser = new DAL.Entity.CLass(user.Name, user.Students);
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

                var classes = _mapper.Map<List<GetVm>>(result);


                var students = result
                    .SelectMany(c => c.Students)
                    .Where(u => u.UserType == Sempa.DAL.Enum.UserType.Student)
                    .ToList();


                var teachers = result
                    .SelectMany(c => c.Students)
                    .Where(u => u.UserType == Sempa.DAL.Enum.UserType.Teacher)
                    .ToList();

                return (true, classes, students, teachers, null);
            }

            return (false, null, null, null, "Failed to Get All Classes :( ");
        }
        public (bool, List<GetClassVm>?, string?) GetAllClasses()
        {
            var result = classRepo.GetAll();
            if (result != null && result.Any())
            {
                var classVmList = _mapper.Map<List<GetClassVm>>(result);
                return (true, classVmList, null);
            }
            return (false, null, "No classes found :(");
        }

    }
}
