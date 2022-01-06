namespace Dependency_Injection.CLI
{
    public class ConsoleOutput : IOutput
    {
        public void Output(string message)
        {
            Console.WriteLine($"\n{message}");
        }
    }
}
