namespace Student.DAL.Repo.Abstraction
{
    public interface IUserRepo
    {
        ( bool , string? ) create(User user);
        (List<User> , string? ) GetAll();
        (User , string? ) GetById(int id);
        (List<User>, string?) GetAll(Expression<Func<User, bool>> Filter);


    }
}
