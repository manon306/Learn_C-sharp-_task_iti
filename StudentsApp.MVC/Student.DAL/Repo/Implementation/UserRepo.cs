using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Student.DAL.Repo.Implementation
{
    public class UserRepo : IUserRepo
    {
        private readonly StudentDbContext DB;
        public UserRepo()
        {
            DB = new();
        }
        public (bool, string?) create(User user)
        {
            try
            {
                var result = DB.Users.Add(user);
                
                DB.SaveChanges();
                if (result.Entity.ID > 0)
                {
                    return (true, null);
                }
                return (false, "there are Problem in Db ");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (List<User>, string?) GetAll()
        {
            try
            {
                var result = DB.Users.ToList();
                if(result.Count == null)
                {
                    return (null, "There is no data");
                }
                return (result, null);
            }
            catch(Exception ex) 
            {
                return (null, ex.Message);
            }
        }
        public (List<User>, string?) GetAll(Expression<Func<User, bool>> Filter)
        {
            try
            {
                var result = DB.Users.Where(Filter).ToList();
                if (result.Count == null)
                {
                    return (null, "There is no data");
                }
                return (result, null);
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }

        public (User, string?) GetById(int id)
        {
            try
            {
                var result =DB.Users.Select(a=>a).Where(a=>a.ID == id).First();
                if (result == null)
                {
                    return (null, "User Not Found");
                }
                return (result,null);
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }
    }
}
