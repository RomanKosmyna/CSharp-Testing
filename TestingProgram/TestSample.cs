class TestSample
{
    private Dictionary<int, string> _userAnswer;
    public string Question {  get; set; }
    public List<Dictionary<int, string>> Options { get; set; }
    public Dictionary<int, string> CorrectAnswer { get; set; }

    public TestSample(string question, List<Dictionary<int, string>> options, Dictionary<int, string> correctAnswer)
    {
        Question = question;
        Options = options;
        CorrectAnswer = correctAnswer;
    }

    public void RunTest()
    {
        Console.WriteLine(Question);

        foreach(var option in Options)
        {
            foreach(var value in option)
            {
                Console.WriteLine($"{value.Key}. {value.Value}");
            }
        }

        var answer = ParseUserAnswer();
        
        IsAnswerCorrect(answer);
    }

    public static int ParseUserAnswer()
    {
        Console.Write("\n");
        Console.Write("Your answer is: ");
        string answer = Console.ReadLine();

        if (int.TryParse(answer, out int parsedAnswer))
        {
            return parsedAnswer;
        }
        else
        {
            return 0;
        }
    }

    public bool IsAnswerCorrect(int answer)
    {
        foreach (var option in Options)
        {
            if (option.ContainsKey(answer))
            {
                _userAnswer = option;
                break;
            }
        }
        
        var result = _userAnswer.Keys.All(key => CorrectAnswer.ContainsKey(key) && CorrectAnswer[key] == _userAnswer[key]);
        
        if (result)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This is a correct answer!");
            Console.ResetColor();
            return true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This is an incorrect answer!");
            Console.ResetColor();
            return false;
        }
    }
}