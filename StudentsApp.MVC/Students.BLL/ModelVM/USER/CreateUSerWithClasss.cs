using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.BLL.ModelVM.USER
{
    public class CreateUSerWithClasss
    {
        public User student { get; set; }
        public List<Student.DAL.Entity.Class>  classes { get; set; }
    }
}
