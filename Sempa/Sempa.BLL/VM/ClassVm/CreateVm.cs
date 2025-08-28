namespace Sempa.BLL.VM.ClassVm
{
    public class CreateVm
    {
        public int ID { get;  set; }
        public string Name { get;  set; }
        public virtual List<User> Students { get;  set; }
    }
}
