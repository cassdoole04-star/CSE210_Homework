using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        List<string> prompts = new List<string>
        {
            "What was the best part of your day?",
            "What are you grateful for today?",
            "Describe a challenge you faced and how you overcame it.",
            "What is a goal you want to achieve this week?",
            "Write about a memorable moment from your childhood."
        };

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to a file");
            Console.WriteLine("4. Load entries from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry newEntry = new Entry();
                Random random = new Random();
                int Index = random.Next(prompts.Count);
                newEntry._promptText = prompts[Index];
                Console.WriteLine(newEntry._promptText);
                newEntry._entryText = Console.ReadLine();
                newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
                theJournal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string saveFile = Console.ReadLine();
                theJournal.SaveToFile(saveFile);
            }
        }
    }
}