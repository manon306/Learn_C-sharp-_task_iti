namespace Sempa.DAL.Repo.Abstraction
{
    public interface IClassRepo
    {
        bool Create(CLass user);
        bool Update(int id, CLass user);
        bool Delete(int id);
        CLass GetById(int id);
        List<CLass> GetAll();
    }
}
