namespace Dependency_Injection.Models
{
    public class User
    {
        public string Name { get; set; } = "User";

        public string? MiddleName { get; set; } 

        public string? LastName { get; set; } 

        public DateTime BirthdayDate { get; set; }
    }
}
