
// Listing activity
public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void PerformActivity()
    {
        Console.WriteLine("Random prompt: " + GetRandomPrompt());
        Console.WriteLine("Get ready to list items...");

        Thread.Sleep(5000); // Pause for 5 seconds to allow thinking

        Console.WriteLine("Start listing items...");
        int itemCount = 0;

        while (Duration > 0)
        {
            string item = Console.ReadLine();

            if (string.IsNullOrEmpty(item))
                break;

            itemCount++;
            Duration--;
        }

        Console.WriteLine($"You've listed {itemCount} items.");
        Countdown(3);
        Console.WriteLine($"You've completed Listing Activity for {Duration} seconds!");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, prompts.Length);
        return prompts[index];
    }
}