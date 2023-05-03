using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.jobTitle = "Database Administrator";
        job1.company = "Melaleuca";
        job1.startYear = 2001;
        job1.endYear = 2015;

        Job job2 = new Job();
        job2.jobTitle = "IT Director";
        job2.company = "INL";
        job2.startYear = 2015;
        job2.endYear = 2021;

        Resume myResume = new Resume();
        myResume.name = "Austin Judkins";

        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.resumeInformation();
    }
}

class Job 
{
    public string jobTitle;
    public string company;
    public int startYear;
    public int endYear;

    public void jobDescription()
    {
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }
}

class Resume
{
    public string name;
    public List<Job> jobs = new List<Job>();

    public void resumeInformation()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");
            
            foreach (Job job in jobs)
            {
                job.jobDescription();
            }
    }
}