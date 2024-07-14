public class EternalGoal : Goal
{
    public override void DisplayProgress()
    {
        string status = IsCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description} (Eternal goal)");
    }
}