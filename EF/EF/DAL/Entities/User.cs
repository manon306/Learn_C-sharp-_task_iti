
namespace EF_Core.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EF_Core.DAL.Enum.type Type { get; set; }
        public List<Post> posts { get; set; }
        public Computer? Computer { get; set; }
    }
}
