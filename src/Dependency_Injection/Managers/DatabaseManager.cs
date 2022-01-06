namespace Dependency_Injection.Managers
{
    internal class DatabaseManager
    {
        public DatabaseManager(IDatabase _db, IOutput output)
        {
            //Print to console.
            output.Output(_db.GetUsers[0].Name);
        }
    }
}
