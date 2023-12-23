public static class TestRunner
{
    private readonly static TestsInitialization testsInitialization = new();
    private readonly static List<Test>? listOfTests = testsInitialization.ListOfTests;

    private readonly static TestCounter counter = new(listOfTests.Count);

    private readonly static List<bool> listOfUserAnswers = [];

    public static List<bool> ListOfUserAnswers { get { return listOfUserAnswers; } }

    public static void Run()
    {
        foreach (var test in listOfTests)
        {
            counter.StartCounter();

            var testResult = test.RunTest();
            listOfUserAnswers.Add(testResult);

            Timer.Run();
        }
    }
}