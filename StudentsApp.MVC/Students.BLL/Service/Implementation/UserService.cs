using Student.DAL.Entity;
using Student.DAL.Repo.Abstraction;
using Student.DAL.Repo.Implementation;

namespace Students.BLL.Service.Implementation
{
    public class UserService :IUserService
    {

        IUserRepo userRepo;
        IClassRepo classRepo;
        public UserService()
        {
            userRepo = new UserRepo();
        }
        public (List<GetAllUser>, string?, bool) GetAll()
        {
            try
            {
                var result = userRepo.GetAll();
                if (result.Item2 != null)
                {
                    return (null, result.Item2, true);
                }
                List<GetAllUser> getAllUser = new List<GetAllUser>();
                foreach (var item in result.Item1)
                {
                    getAllUser.Add(new GetAllUser { Name = item.Name, age = item.age });
                }

                return (getAllUser, null, false);
            }
            catch (Exception ex) 
            {
                return (null, ex.Message, true);
            }

        }
        public (bool, string?) Create(User user)
        {
            try
            {
                var r = userRepo.create(user);

                return r;
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
