namespace Student.DAL.Repo.Implementation
{
    public class TeacheRepo :ITeacheRepo
    {
        private readonly StudentDbContext DB;
        public TeacheRepo()
        {
            DB = new();
        }
        public (bool, string?) create(Teacher t)
        {
            try
            {
                var result = DB.Teachers.Add(t);
                DB.SaveChanges();
                if (result.Entity.Id> 0)
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

        public (List<Teacher>, string?) GetAll()
        {
            try
            {
                var result = DB.Teachers.ToList();
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
        public (List<Teacher>, string?) GetAll(Expression<Func<Teacher, bool>> Filter)
        {
            try
            {
                var result = DB.Teachers.Where(Filter).ToList();
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

        public (Teacher, string?) GetById(int id)
        {
            try
            {
                var result = DB.Teachers.Select(a => a).Where(a => a.Id == id).First();
                if (result == null)
                {
                    return (null, "User Not Found");
                }
                return (result, null);
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }
    }
}
