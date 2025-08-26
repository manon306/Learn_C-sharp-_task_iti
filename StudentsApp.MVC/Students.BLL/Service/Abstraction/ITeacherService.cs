using Student.DAL.Entity;
using Students.BLL.ModelVM.Teacher;
namespace Students.BLL.Service.Abstraction
{
    public interface ITeacherService
    {
        (List<GetAllTeacher>, string?, bool) GetAll();
        (bool, string?) Create(Teacher t);

    }
}
