
namespace Sempa.DAL.Repo.Implementation
{
    public class UserRepo : IUserRepo
    {
        private readonly SempaDbContext DB;
        public UserRepo(SempaDbContext db)
        {
            DB = db;
        }

        public bool Create(User user)
        {
            try
            {
                DB.Users.Add(user);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var result = DB.Users.FirstOrDefault(u => u.Id == id);
                if (result != null)
                {
                    DB.Users.Remove(result);
                    DB.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            try
            {
                if (filter == null)
                    return DB.Users.ToList();

                return DB.Users.Where(filter).ToList();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public User GetById(int id)
        {
            try
            {
                return DB.Users.FirstOrDefault(u => u.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public bool Update(int id, User user)
        {
            try
            {
                var result = DB.Users.FirstOrDefault(u => u.Id == id);
                if (result != null)
                {
                    result.Update(user.FirstName, user.LastName, user.Email, user.Password);
                    DB.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool ToggleStatus(int id)
        {
            try
            {
                var result = DB.Users.FirstOrDefault(u => u.Id == id);
                if (result != null)
                {
                    result.ToggleStatus("Menna");
                    DB.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

    }
}
