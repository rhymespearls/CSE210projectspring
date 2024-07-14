public class Program
{
    private static List<Goal> goals = new List<Goal>();

    public static void Main(string[] args)
    {
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

            Console.Write("Enter your choice (1-6): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateNewGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void CreateNewGoal()
    {
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        Console.WriteLine();

        Console.Write("Enter goal type (1-3): ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points associated: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;

        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal();
                break;
            case 2:
                goal = new EternalGoal();
                break;
            case 3:
                goal = new ChecklistGoal();
                Console.Write("Enter target count: ");
                ((ChecklistGoal)goal).TargetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                ((ChecklistGoal)goal).BonusPoints = int.Parse(Console.ReadLine());
                break;
            default:
                Console.WriteLine("Invalid goal type. Try again.");
                return;
        }

        goal.Name = name;
        goal.Description = description;
        goal.Points = points;

        goals.Add(goal);

        Console.WriteLine("Goal created successfully.");
    }

    private static void ListGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
        else
        {
            Console.WriteLine("Goals:");
            foreach (Goal goal in goals)
            {
                goal.DisplayProgress();
            }
        }
    }

    private static void SaveGoals()
    {
        // Implement your code to save the goals to a file or database
        Console.WriteLine("Goals saved successfully.");
    }

    private static void LoadGoals()
    {
        // Implement your code to load the goals from a file or database
        Console.WriteLine("Goals loaded successfully.");
    }

    private static void RecordEvent()
    {
        Console.Write("Enter goal name: ");
        string goalName = Console.ReadLine();

        Goal goal = goals.Find(g => g.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));

        if (goal != null)
        {
            goal.MarkComplete();
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Goal not found. Try again.");
        }
    }
}