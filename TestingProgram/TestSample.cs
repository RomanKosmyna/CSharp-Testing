class TestSample
{
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
    }
}