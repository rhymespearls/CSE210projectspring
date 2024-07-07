using System;

// Main program
public class MindfulnessApp
{
    public static void Main()
    {
        while (true)
        {
            DisplayMenu();

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 0)
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }
                else if (choice >= 1 && choice <= 3)
                {
                    Activity activity;

                    if (choice == 1)
                        activity = new BreathingActivity();
                    else if (choice == 2)
                        activity = new ReflectionActivity();
                    else
                        activity = new ListingActivity();

                    Console.Write("Enter duration in seconds: ");
                    if (int.TryParse(Console.ReadLine(), out int duration))
                    {
                        activity.Duration = duration;
                        activity.Start();
                    }
                    else
                    {
                        Console.WriteLine("Invalid duration. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }

            Console.WriteLine();
        }
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Mindfulness App");
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");
    }
}