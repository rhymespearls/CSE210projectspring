// Breathing activity
public class BreathingActivity : Activity
{
    public override void PerformActivity()
    {
        Console.WriteLine("Breathe in...");
        Countdown(Duration);

        Console.WriteLine("Breathe out...");
        Countdown(Duration);

        Console.WriteLine($"You've completed Breathing Activity for {Duration} seconds!");
    }
}