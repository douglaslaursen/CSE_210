using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Address address = new Address("100 W", "Price", "UT", "USA");
        Lectures lecture = new Lectures(100, "Dave", "Dave's Ted Talk", "Here dave...", "12/10/2026", "1:00am", address);
        lecture.DisplayFullDetails();
        lecture.DisplayShortDetails();
    }
}