public class TestCounter
{
    private List<int> counterList = [];
    private int currentIndex = 1;

    public TestCounter(int testListCount)
    {
        for (int i = 0; i <= testListCount; i++)
        {
            counterList.Add(i);
        }
    }

    public void StartCounter()
    {
        if (currentIndex >= 0 && currentIndex < counterList.Count)
        {
            Console.WriteLine($"Test №{currentIndex} | {currentIndex}/10");
            Console.Write("\n");

            currentIndex++;
        }
    }
}