using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1._firstName = "Zack";
        p1._lastName = "Doe";
        p1._age = 30;

        Person p2 = new Person();
        p2._firstName = "Jane";
        p2._lastName = "Smith";
        p2._age = 25;

        List<Person> people = new List<Person> {};
        people.Add(p1);
        people.Add(p2);

        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person._firstName} {person._lastName}, Age: {person._age}");
        }

        SaveToFile(people);
        List<Person> readPeople = ReadFromFile("people.txt");
        Console.WriteLine("People read from file:");
        foreach (Person person in readPeople)
        {
            Console.WriteLine($"Name: {person._firstName} {person._lastName}, Age: {person._age}");
        }
    }

    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving people to file...");

        string filename = "people.txt";

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputfile.WriteLine($"{p._firstName}~~~{p._lastName}~~~{p._age}");
            }
        }
    }

    public static List<Person> ReadFromFile(string filename)
    {
        List<Person> people = new List<Person>();

        using (StreamReader inputfile = new StreamReader(filename))
        {
            string line;
            while ((line = inputfile.ReadLine()) != null)
            {
                string[] parts = line.Split("~~~");
                Person p = new Person();
                p._firstName = parts[0];
                p._lastName = parts[1];
                p._age = int.Parse(parts[2]);
                people.Add(p);
            }
        }

        return people;
    }
}