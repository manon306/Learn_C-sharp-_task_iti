namespace Student.DAL.Repo.Implementation
{
    public class ClassRepo : IClassRepo
    {
        private readonly StudentDbContext DB;
        public ClassRepo()
        {
            DB = new ();
        }

        public (bool, string?) Create(Class c)
        {
            try
            {
                
                var r = DB.classes.Add(c);
                DB.SaveChanges();
                if (r.Entity.Id > 0)
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

        public (List<Class>, string?) GetAll()
        {
            try
            {
                var result = DB.classes
                                    .Include(c => c.users)
                                    .Include(c => c.teachers)
                                    .ToList();
                if (result == null|| result.Count == 0)
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
        public (List<Class>, string?) GetAllC()
        {
            try
            {
                var classes = DB.classes.ToList();
                return (classes, null);
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }
    }
}
