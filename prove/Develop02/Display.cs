using System;
using System.Collections.Generic;

class Display
{
    public static void DisplayJournal(List<Entry> journal)
    {
        if (journal.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
        }
        else
        {
            Console.WriteLine("Journal entries:");
            foreach (Entry entry in journal)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
