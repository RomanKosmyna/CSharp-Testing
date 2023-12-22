public static class TestRunner
{
    private readonly static TestsInitialization testsInitialization = new();
    private readonly static List<Test>? listOfTests = testsInitialization.ListOfTests;

    private readonly static TestCounter counter = new(listOfTests.Count);

    public static void Run()
    {
        foreach (var test in listOfTests)
        {
            counter.StartCounter();
            test.RunTest();
            Timer.Run();
        }
    }
}