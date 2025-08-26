using AutoMapper;
using Sempa.BLL.Helper;

namespace Sempa.BLL.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepo userRepo;
        private readonly IMapper _mapper;

        public UserService(IUserRepo userRepo, IMapper mapper)
        {
            this.userRepo = userRepo;
            _mapper = mapper;
        }
        public (bool, string?) Create(CreateUserVm user)
        {
            //Get image Path
            var imagePath= Upload.UploadFile("Files", user.Profile);


            var newUser = new User(user.FirstName,user.LastName,user.Email , user.Password,imagePath);
            var result = userRepo.Create(newUser);
            if (result)
            {
                return (true, null);
            }
            return (false, "Failed to create user. :=(");
        }
        public (bool, List<GetAllVm>?, string?) GetAll()
        {
            var result = userRepo.GetAll();

            if (result != null && result.Any())
            {
                
                var users = _mapper.Map<List<GetAllVm>>(result);

                return (true, users, null);
            }

            return (false, null, "Failed to Get All Users :( ");
        }


    }
}
