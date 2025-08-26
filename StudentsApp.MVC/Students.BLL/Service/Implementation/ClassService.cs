using Student.DAL.Repo.Abstraction;
using Student.DAL.Repo.Implementation;
using Students.BLL.ModelVM.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.BLL.Service.Implementation
{
    public class ClassService : IClassService
    {
        IClassRepo ClassRepo;
        public ClassService()
        {
            ClassRepo = new ClassRepo();
        }
        public (bool, string?) Create(Class c)
        {
            try
            {
                var t = ClassRepo.Create(c);
                return t;
            }
            catch(Exception ex) 
            { 
                return (false, ex.Message);
            }

        }

        public (List<GetAllClass>, string?, bool) GetAll()
        {
            try
            {
                var r = ClassRepo.GetAll();
                if (r.Item2 != null)
                {
                    return (null, r.Item2, true);
                }

                List<GetAllClass> getAllClasses = new();
                foreach (var item in r.Item1)
                {
                    getAllClasses.Add(new GetAllClass
                    {
                        name = item.name,
                        users = item.users,
                        teachers = item.teachers
                    });
                }

                return (getAllClasses, null, false);
            }
            catch (Exception e)
            {
                return (null, e.Message, true);
            }
        }

    }
}
