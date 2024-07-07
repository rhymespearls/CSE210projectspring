// Reflection activity
public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public override void PerformActivity()
    {
        Console.WriteLine("Random prompt: " + GetRandomPrompt());

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            Console.WriteLine("Spinner animation...");
            Thread.Sleep(2000); // Pause for 2 seconds
        }

        Countdown(Duration);
        Console.WriteLine($"You've completed Reflection Activity for {Duration} seconds!");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, prompts.Length);
        return prompts[index];
    }
}