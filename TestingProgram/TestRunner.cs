static class TestRunner
{
    private readonly static TestsInitialization testsInitialization = new();
    private readonly static List<TestSample>? listOfTests = testsInitialization.ListOfTests;

    public static void Run()
    {
        listOfTests[0].RunTest();
        Timer.Run();
        listOfTests[1].RunTest();
        Timer.Run();
        listOfTests[2].RunTest();
        Timer.Run();
        listOfTests[3].RunTest();
        Timer.Run();
    }
}