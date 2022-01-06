namespace Dependency_Injection.Databases
{
    internal class SqlDatabase : IDatabase
    {
        public List<User> GetUsers
        {
            get
            {
                return new List<User> { new User() { Name = "Administrator (Sql)" } };
            }
        }
    }
}
