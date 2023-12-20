class Test : ISingleCorrectAnswerTest
{
    private Dictionary<int, string> _chosenOption;
    public List<Dictionary<int, string>> Options { get; set; }
    public Dictionary<int, string> CorrectOption { get; set; }

    public Test(List<Dictionary<int, string>> options, Dictionary<int, string> correctOption)
    {
        Options = options;
        CorrectOption = correctOption;
    }

    public void RunTest(string answer)
    {
        int parsedAnswer = int.Parse( answer );

        if ( answer == null )
        {
            return;
        }

        foreach (var option in Options)
        {
            if (option.ContainsKey(parsedAnswer))
            {
                _chosenOption = option;
                break;
            }
        }

        var result = _chosenOption.Keys.All(key => CorrectOption.ContainsKey(key) && CorrectOption[key] == _chosenOption[key]);

        if (result)
        {
            Console.WriteLine("Ваша відповідь є вірною!");
        }
        else
        {
            Console.WriteLine("Ваша відповідь є хибною!");
        }
    }

    public void LogAllOptions()
    {
        foreach (var option in Options)
        {
            foreach(var key in option)
            {
                Console.WriteLine($"{key.Key}. {key.Value}");
            }
        }
    }
}