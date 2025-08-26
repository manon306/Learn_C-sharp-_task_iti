using Students.BLL.ModelVM.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.BLL.Service.Abstraction
{
    public interface IClassService
    {
        (List<GetAllClass>, string?, bool) GetAll();
        (bool, string?) Create(Class c);
    }
}
