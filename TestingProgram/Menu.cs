public static class Menu
{
    public static string Run()
    {
        Console.WriteLine("To answer a test, type a number of option you think is correct.");
        Console.WriteLine("Like so: 1. If you think there is few correct answers, type like so: 1 3.");
        Console.WriteLine("\n");
        Console.Write("To start a test type start: ");
        string start = Console.ReadLine();

        return start;
    }
}