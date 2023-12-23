public static class TestRunner
{
    private readonly static TestsInitialization testsInitialization = new();
    private readonly static List<Test>? listOfTests = testsInitialization.ListOfTests;

    private readonly static TestCounter counter = new(listOfTests.Count);

    private readonly static List<Dictionary<int, bool>> listOfUserAnswers = [];

    public readonly static int totalTestPoints = 0;

    static TestRunner()
    {
        foreach (var test in listOfTests)
        {
            totalTestPoints += test.PointsForCorrectAnswer;
        }
    }

    public static List<Dictionary<int, bool>> ListOfUserAnswers { get { return listOfUserAnswers; } }

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