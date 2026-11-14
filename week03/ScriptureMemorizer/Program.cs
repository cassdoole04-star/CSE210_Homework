using System;

/*
 * Exceeds core requirements:
 * 1. Randomly hides only from words that are NOT already hidden, instead of
 *    picking any word (which could hide the same word repeatedly).
 * 2. Type "hint" instead of pressing enter to reveal one random hidden word,
 *    to help when memorizing a difficult verse.
 */
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi 22", 9, 14);
        Scripture scripture = new Scripture(reference,
            "God's covenant will bless all people, and those who oppose Zion will be overcome by their own wickedness.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(reference.GetReference());
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words, type a word to reveal it, 'hint' to reveal a random word, or 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else if (input == "hint")
            {
                scripture.RevealRandomWord();
            }
            else if (input.Length == 0)
            {
                scripture.HideRandomWords(3);
            }
            else
            {
                scripture.RevealWord(input);
            }
        }
    }
}