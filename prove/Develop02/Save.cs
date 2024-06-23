
using System;
using System.IO;

class Save
{
    public static void SaveJournalToFile(List<Entry> journal)
    {
        if (journal.Count == 0)
        {
            Console.WriteLine("Journal is empty. Nothing to save.");
            return;
        }

        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in journal)
            {
                writer.WriteLine($"{entry._Prompt}|{entry._Response}|{entry._Date}");
            }
        }

        Console.WriteLine("Journal saved to file.");
    }
}
