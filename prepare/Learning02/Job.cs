using System;

class Job
{
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void displayJob()
    {
        Console.WriteLine($"\nCompany Name: {_companyName}, Title: {_jobTitle}, Started: {_startYear}, Ended: {_endYear}\n");
    }
}