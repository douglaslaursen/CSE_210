using System;

class Resume
{
    public string _name;

    public List<Job> _jobs;

    public void DisplayResume()
    {
        Console.WriteLine($"\nName: {_name}");

        foreach(Job job in _jobs)
        {
            // Console.WriteLine(job);
            job.displayJob();
        }
    }
}