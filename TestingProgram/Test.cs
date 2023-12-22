public class Test
{
    private static string? Question { get; set; }
    private static readonly List<Dictionary<int, string>> listOfOptions = [];
    private static readonly List<Dictionary<int, string>> listOfCorrectOptions = [];

    public static void AddQuestion(string question)
    {
        Question = question;
    }

    public void AddOption(int key, string value)
    {
        Dictionary<int, string> option = [];
        option.Add(key, value);
        listOfOptions.Add(option);
    }

    public void AddCorrectOption(int key, string value)
    {
        Dictionary<int, string> correctOption = [];
        correctOption.Add(key, value);
        listOfCorrectOptions.Add(correctOption);
    }

    public static void RunTest()
    {
        LogOptions();

        Console.Write("\n");
        Console.Write("Your answer is: ");
        var answer = GetAnswer();

        CheckAnswer(answer);
    }

    private static void LogOptions()
    {
        Console.WriteLine(Question);

        foreach (var option in listOfOptions)
        {
            foreach (var keyValuePair in option)
            {
                Console.WriteLine($"{keyValuePair.Key}. {keyValuePair.Value}");
            }
        }
    }

    private static Dictionary<int, string>? GetAnswer()
    {
        var answer = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(answer))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return null;
        }

        var answerParts = answer.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var selectedOptions = new Dictionary<int, string>();

        foreach (var part in answerParts)
        {
            if (int.TryParse(part, out int parsedPart))
            {
                foreach (var option in listOfOptions)
                {
                    if (option.ContainsKey(parsedPart))
                    {
                        selectedOptions.Add(parsedPart, option[parsedPart]);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Invalid input: {part}. Please enter valid numbers.");
                return null;
            }
        }

        return selectedOptions;
    }

    public static void CheckAnswer(Dictionary<int, string> answer)
    {
        bool checkAnswer = false;

        if (listOfCorrectOptions.Count != answer.Count)
        {
            Logger.IncorrectAnswer(listOfCorrectOptions);
            return;
        }

        foreach (var correctOption in listOfCorrectOptions)
        {
            checkAnswer = correctOption.All(correctKeyValuePair => answer.Any(answerKeyValuePair =>
                answerKeyValuePair.Key == correctKeyValuePair.Key &&
                answerKeyValuePair.Value == correctKeyValuePair.Value
            ));

            if (!checkAnswer)
            {
                break;
            }
        }

        if (checkAnswer)
        {
            Logger.CorrectAnswer();
        }
        else
        {
            Logger.IncorrectAnswer(listOfCorrectOptions);
        }
    }
}