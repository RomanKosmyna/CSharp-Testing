do
{
    string start = Menu.Run();

    if (start == "start")
    {
        Console.Clear();
        TestRunner.Run();
    }

    var listOfResults = TestRunner.ListOfUserAnswers;
    var totalPoints = TestRunner.totalTestPoints;

    TestResult.ShowResult(listOfResults, totalPoints);

    Console.ReadKey();
}
while (true);