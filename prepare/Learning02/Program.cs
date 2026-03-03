using System;

class Program
{
    static void Main(string[] args)
    {
        Job myFirstJob = new Job();

        myFirstJob._companyName = "Digitran";
        myFirstJob._jobTitle = "Software Engineer";
        myFirstJob._startYear = 1989;
        myFirstJob._endYear = 1994;

        myFirstJob.displayJob();

        // Job mySecondJob = new Job();  //Not related in any way so will print nothing...
        // mySecondJob.displayJob(); 
    
        Job mySecondJob = new Job();

        mySecondJob._companyName = "HP";
        mySecondJob._jobTitle = "Software Engineer";
        mySecondJob._startYear = 1994;
        mySecondJob._endYear = 2022;
        
        mySecondJob.displayJob();
    }
}