// Base class for all activities
public abstract class Activity
{
    public int Duration { get; set; }

    public abstract void PerformActivity();

    public void Start()
    {
        Console.WriteLine("Prepare to begin...");
        Countdown(5);
        PerformActivity();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); // Pause for 1 second
        }
    }
}