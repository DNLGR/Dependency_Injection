namespace Dependency_Injection.Intefaces
{
    public interface IDatabase
    {
        List<User> GetUsers { get; }
    }
}
