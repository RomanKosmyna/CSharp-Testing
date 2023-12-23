do
{
    string start = Menu.Run();

    if (start == "start")
    {
        Console.Clear();
        TestRunner.Run();
    }

    var listOfResults = TestRunner.ListOfUserAnswers;

    TestResult.ShowResult(listOfResults);

    Console.ReadKey();
}
while (true);