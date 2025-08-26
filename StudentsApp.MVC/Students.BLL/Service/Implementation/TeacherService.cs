using Student.DAL.Entity;
using Student.DAL.Repo.Abstraction;
using Student.DAL.Repo.Implementation;
using Students.BLL.ModelVM.Teacher;

namespace Students.BLL.Service.Implementation
{
    public class TeacherService : ITeacherService
    {

        ITeacheRepo TRepo;
        public TeacherService()
        {
            TRepo = new TeacheRepo();
        }
        public (bool, string?) Create(Teacher t)
        {
           try
           {
                var r = TRepo.create(t);
                return r;
           }
           catch(Exception ex) 
           {
                return (false, ex.Message);
           }
        }

        public (List<GetAllTeacher>, string?, bool) GetAll()
        {
            try
            {
                var r = TRepo.GetAll();
                if (r.Item2 != null)
                {
                    return (null, r.Item2, true);
                }
                List<GetAllTeacher> getAllTeachers = new();
                foreach (var item in r.Item1)
                {
                    getAllTeachers.Add(new GetAllTeacher { age = item.age, Name = item.Name });
                }
                return (getAllTeachers, null, false);
            }
            catch(Exception e)
            {
                return(null ,e.Message,true);
            }
        }
    }
}
