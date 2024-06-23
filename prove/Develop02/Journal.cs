public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void WriteNewEntry()
    {
        Console.WriteLine("Select a prompt:");

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What would it be if I had one thing I could do over today?",
            "My Own Entry"
        };

        for (int i = 0; i < prompts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }

        Console.Write("Enter the prompt number: ");
        int promptNumber;
        if (int.TryParse(Console.ReadLine(), out promptNumber) && promptNumber >= 1 && promptNumber <= prompts.Count)
        {
            string prompt = prompts[promptNumber - 1];
            Console.Write("Enter your response: ");
            string response = Console.ReadLine();
            Entry entry = new Entry(prompt, response, DateTime.Now);
            entries.Add(entry);
            Console.WriteLine("Entry saved.");
        }
        else
        {
            Console.WriteLine("Invalid prompt number. Entry not saved.");
        }
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
        }
        else
        {
            Console.WriteLine("Journal entries:");
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveJournalToFile()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Journal is empty. Nothing to save.");
            return;
        }

        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry._Prompt}|{entry._Response}|{entry._Date}");
            }
        }

        Console.WriteLine("Journal saved to file.");
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter a filename to load the journal from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string prompt = parts[0];
                    string response = parts[1];
                    DateTime date = DateTime.Parse(parts[2]);
                    Entry entry = new Entry(prompt, response, date);
                    entries.Add(entry);
                }
            }
        }

        Console.WriteLine("Journal loaded from file.");
    }
}

