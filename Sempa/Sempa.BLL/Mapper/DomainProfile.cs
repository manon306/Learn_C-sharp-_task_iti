using AutoMapper;
namespace Sempa.BLL.Mapper
{
    public class DomainProfile :Profile
    {
        public DomainProfile()
        {
            CreateMap<User,GetAllVm>().ReverseMap();
        }
    }
}
