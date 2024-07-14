public class SimpleGoal : Goal
{
    public override void DisplayProgress()
    {
        string status = IsCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description} ({Points} points)");
    }
}