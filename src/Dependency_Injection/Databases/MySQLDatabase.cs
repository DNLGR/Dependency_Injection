namespace Dependency_Injection.Databases
{
    internal class MySQLDatabase : IDatabase
    {
        public List<User> GetUsers
        {
            get
            {
                return new List<User> { new User() { Name = "Administrator (MySql)" } };
            }
        }
    }
}
