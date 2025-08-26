public class User
{
    public User(string firstName, string lastName, string email, string password, string imagePath)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        CreatedAt = DateTime.Now;
        this.imagePath = imagePath;
    }

    public int Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public DateTime ModifiedIn { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public bool IsDeleted { get; private set; }
    public bool IsUpdated { get; private set; }
    public string imagePath { get; private set; }
    public bool Update(string MfirstName, string MlastName, string email, string password)
    {
        if(string.IsNullOrEmpty(MfirstName)|| string.IsNullOrEmpty(MlastName))
        {
            return false;
        }
        FirstName = MfirstName;
        LastName = MlastName;
        Email = email;
        Password = password;
        UpdatedAt = DateTime.Now;
        ModifiedIn = DateTime.Now;
        IsUpdated = true;
        return true;
    }
    public bool ToggleStatus(String DeletedUser)
    {
        if (string.IsNullOrEmpty(DeletedUser))
        {
            return false;
        }
        IsDeleted = ! IsDeleted;
        return true;
    }
}
