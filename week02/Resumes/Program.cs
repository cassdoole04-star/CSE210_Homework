using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Game Developer";
        job1._company = "MoJang";
        job1._startYear = 2000;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Technisian";
        job2._company = "Best Buy";
        job2._startYear = 2020;
        job2._endYear = 2060;

        Resume myResume = new Resume();
        myResume._name = "John Doe";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
    public class Job
    {
        public string _jobTitle;
        public string _company;
        public int _startYear;
        public int _endYear;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }
    public class Resume
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();

        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }
    }
}