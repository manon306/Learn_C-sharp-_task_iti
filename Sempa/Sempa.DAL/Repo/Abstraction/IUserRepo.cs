namespace Sempa.DAL.Repo.Abstraction
{
    public interface IUserRepo
    {
        bool Create(User user);
        bool Update(int id, User user);
        bool Delete(int id);
        User GetById(int id);
        List<User> GetAll(Expression<Func<User, bool>> filter = null);
        
    }
}
