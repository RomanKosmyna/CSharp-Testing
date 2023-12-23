public class TestResult
{
    private static int _index = default;

    public static void ShowResult(List<Dictionary<int, bool>> listOfUserAnswers, int totalPoints)
    {
        foreach (var answer in listOfUserAnswers)
        {
            foreach (var KeyValuePair in answer)
            {
                if (KeyValuePair.Key == 1 && KeyValuePair.Value)
                {
                    _index++;
                }

                if (KeyValuePair.Key == 2 && KeyValuePair.Value)
                {
                    _index += 2;
                }
            }
        }

        double percentageRate = ((_index / (double)totalPoints) * 100);

        Console.WriteLine($"Your result is {_index} out of {totalPoints} points, which is {percentageRate}%.");
    }
}