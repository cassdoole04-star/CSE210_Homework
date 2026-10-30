using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter  Your Grade Percentage: ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is at: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You Passed! Great Job!");
        }
        else
        {
            Console.WriteLine("Better luck next time!, You Got this!");
        }
    }
}