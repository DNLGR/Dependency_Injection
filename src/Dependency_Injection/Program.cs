var logoMesage = "\t Enter your database letter to continue.\n" +
                 "\t M - MySql\n" +
                 "\t S - Sql\n" +
                 "\n:";

Console.Write(logoMesage);

char letter = char.ToUpper(Console.ReadKey().KeyChar);

if (char.IsLetter(letter))
{
    SelectDatabase(letter);
}

static void SelectDatabase(char letter)
{
    if (letter == 'M')
    {
        _ = new DatabaseManager(new MySQLDatabase(), new ConsoleOutput());

        return;
    }

    if (letter == 'S')
    {
        _ = new DatabaseManager(new SqlDatabase(), new ConsoleOutput());

        return;
    }

    Console.WriteLine("Your'e letter is invalid!");

    Console.WriteLine("Goodby");

    Console.ReadKey();

    Environment.Exit(0);
}