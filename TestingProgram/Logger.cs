public static class Logger
{
    public static void CorrectAnswer()
    {
        Console.Write("\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Correct answer!");
        Console.ResetColor();
    }

    public static void IncorrectAnswer(List<Dictionary<int, string>> correctAnswerList)
    {
        Console.Write("\n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrect answer!");
        Console.ResetColor();
        Console.WriteLine("Correct answer is:");

        foreach (var correctAnswer in correctAnswerList)
        {
            foreach (var answer in correctAnswer)
            {
                Console.WriteLine($"{answer.Key}. {answer.Value}");
            }
        }
    }
}