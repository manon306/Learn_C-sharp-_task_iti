using Student.DAL.Entity;
using Students.BLL.ModelVM.USER;

namespace Students.BLL.Service.Abstraction
{
    public interface IUserService
    {
        (List<GetAllUser>, string? , bool) GetAll() ;
        (bool, string?) Create(User user);

    }
}
