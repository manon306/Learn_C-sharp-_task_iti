using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DAL.Repo.Abstraction
{
    public interface IClassRepo
    {
        (bool, string?) Create(Class c);
        (List<Class>, string?) GetAll();
    }
}
