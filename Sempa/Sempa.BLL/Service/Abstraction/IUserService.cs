
namespace Sempa.BLL.Service.Abstraction
{
    public interface IUserService
    {
        (bool, string?) Create(CreateUserVm user);
        (bool, string?) Create_T(CreateTeacherVm user);
        (bool, List<GetAllVm>?, string?) GetAll();
        (bool, List<GetAllVm>?, string?) GetAll_T();
    }
}
