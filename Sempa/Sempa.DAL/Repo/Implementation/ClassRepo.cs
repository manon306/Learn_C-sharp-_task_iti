
using Sempa.DAL.Entity;

namespace Sempa.DAL.Repo.Implementation
{
    public class ClassRepo : IClassRepo
    {
        private readonly SempaDbContext DB;
        public ClassRepo(SempaDbContext db)
        {
            DB = db;
        }
        public bool Create(CLass user)
        {
            try
            {
                DB.Classes.Add(user);
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
                var result = DB.Classes.FirstOrDefault(u => u.ID == id);
                if (result != null)
                {
                    DB.Classes.Remove(result);
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
        public CLass GetById(int id)
        {
            try
            {
                return DB.Classes.FirstOrDefault(u => u.ID == id);
            }
            catch
            {
                return null;
            }
        }
        public bool Update(int id, CLass user)
        {
            try
            {
                var result = DB.Classes.FirstOrDefault(u => u.ID == id);
                if (result != null)
                {
                    result.Update(user.Name, user.Students);
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
        public List<CLass> GetAll()
        {
            try
            {
                return DB.Classes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
