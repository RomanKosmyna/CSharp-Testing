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
            {2, "public static void Main()"}
        };
        TestSample firstTest = new(firstTestQuestion, firstTestOptions, firstTestCorrectAnswer);
        ListOfTests?.Add(firstTest);
        // test #2 
        string secondTestQuestion = "Which of the followings are value types in C#?";
        List<Dictionary<int, string>> secondTestOptions =
            [
                new Dictionary<int, string> { { 1, "Int32" } },
                new Dictionary<int, string> { { 2, "Double" } },
                new Dictionary<int, string> { { 3, "Decimal" } },
                new Dictionary<int, string> { { 4, "All of the above" } },
            ];
        Dictionary<int, string> secondTestCorrectAnswer = new()
        {
            {4, "All of the above"}
        };
        TestSample secondTest = new(secondTestQuestion, secondTestOptions, secondTestCorrectAnswer);
        ListOfTests?.Add(secondTest);
        // test #3
        string thirdTestQuestion = "Which of the following is a reference type in C#?";
        List<Dictionary<int, string>> thirdTestOptions =
            [
                new Dictionary<int, string> { { 1, "String" } },
                new Dictionary<int, string> { { 2, "Long" } },
                new Dictionary<int, string> { { 3, "Boolean" } },
                new Dictionary<int, string> { { 4, "None of the above" } },
            ];
        Dictionary<int, string> thirdTestCorrectAnswer = new()
        {
            {4, "None of the above"}
        };
        TestSample thirdTest = new(thirdTestQuestion, thirdTestOptions, thirdTestCorrectAnswer);
        ListOfTests?.Add(thirdTest);
        // test #4
        string fourthTestQuestion = "What is the nullable type in C#?";
        List<Dictionary<int, string>> fourthTestOptions =
            [
                new Dictionary<int, string> { { 1, "It allows assignment of null to reference type." } },
                new Dictionary<int, string> { { 2, "It allows assignment of null to value type." } },
                new Dictionary<int, string> { { 3, "It allows assignment of null to static class." } },
                new Dictionary<int, string> { { 4, "None of the above" } },
            ];
        Dictionary<int, string> fourthTestCorrectAnswer = new()
        {
            {2, "It allows assignment of null to value type."}
        };
        TestSample fourthTest = new(fourthTestQuestion, fourthTestOptions, fourthTestCorrectAnswer);
        ListOfTests?.Add(fourthTest);
    }
}