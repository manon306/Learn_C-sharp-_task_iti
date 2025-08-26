using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DAL.Repo.Abstraction
{
    public interface ITeacheRepo
    {
        (bool, string?) create(Teacher t);
        (List<Teacher>, string?) GetAll();
        (List<Teacher>, string?) GetAll(Expression<Func<Teacher, bool>> Filter);
        (Teacher, string?) GetById(int id);
        

    }
}
