namespace Sempa.BLL.Service.Abstraction
{
    public interface IClassService
    {
        (bool, string?) Create(CreateVm user);
        (bool, List<GetVm>?, List<User>?, List<User>?, string?) GetAll();
    }
}
