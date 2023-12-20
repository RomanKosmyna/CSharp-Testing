class TestsInitialization
{
    public List<TestSample>? ListOfTests { get; set; }

    public TestsInitialization()
    {
        ListOfTests = [];
        // test #1
        string firstTestQuestion = "Which of the following methods is an entry point in the C# console program?";
        List<Dictionary<int, string>> firstTestOptions =
            [
                new Dictionary<int, string> { { 1, "public static void Program()" } },
                new Dictionary<int, string> { { 2, "public static void Main()" } },
                new Dictionary<int, string> { { 3, "public static void main()" } },
                new Dictionary<int, string> { { 4, "None of the above" } },
            ];

        Dictionary<int, string> firstTestCorrectAnswer = new()
        {
            {1, "public static void Program()"}
        };
        TestSample firstTest = new(firstTestQuestion, firstTestOptions, firstTestCorrectAnswer);
        ListOfTests?.Add(firstTest);
        // test #2
    }
}