using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.Write("Enter a number(0 to quit): ");

        int userNumber;
        do
        {
            Console.Write(" Enter a number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

        int smallestPositive = int.MaxValue; 
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"  The smallest positive number is: {smallestPositive}");

        // Part 5: Sort and display the list
        numbers.Sort();
        Console.WriteLine("  The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine($"  {number}");
        }
    }
}