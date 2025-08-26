
namespace Sempa.BLL.Service.Abstraction
{
    public interface IUserService
    {
        (bool, string?) Create(CreateUserVm user);
        (bool, List<GetAllVm>?, string?) GetAll();
    }
}
