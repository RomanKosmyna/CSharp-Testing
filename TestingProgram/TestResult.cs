public class TestResult
{
    private static int index = default;

    public static void ShowResult(List<bool> listOfUserAnswers)
    {
        foreach (var answer in listOfUserAnswers)
        {
            if (answer)
            {
                index++;
            }
        }

        double percentageRate = (index / 10.0) * 100;

        Console.WriteLine($"Your result is {index} out of 10, which is {percentageRate}%.");
    }
}