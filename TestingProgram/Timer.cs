static class Timer
{
    private static System.Threading.Timer timer;
    private static bool isTimerActivated = false;

    public static void StartTimer()
    {
        if (!isTimerActivated)
        {
            timer = new System.Threading.Timer(state =>
            {
                Console.Clear();
                isTimerActivated = false;
            }, null, 4000, Timeout.Infinite);

            isTimerActivated = true;
        }
    }

    public static void StopThread()
    {
        while (isTimerActivated)
        {
            Thread.Sleep(100);
        }
    }

    public static void Run()
    {
        StartTimer();
        StopThread();
    }
}