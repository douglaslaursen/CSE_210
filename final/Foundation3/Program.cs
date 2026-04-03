using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address addressLecture1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address addressLecture2 = new Address("49 Learn","Sugur","ID","USA");
        Address addressReception1 = new Address("456 Center St", "Boise", "ID", "USA");
        Address addressReception2 = new Address("159 Marry Me St", "Rigby", "ID", "USA");
        Address addressOutdoorGathering1 = new Address("789 Park Ave", "Salt Lake City", "UT", "USA");
        Address addressOutdoorGathering2 = new Address("153 Nicepark street", "Spanish Fork", "UT", "USA");


        List<Event> events = new List<Event>();

        events.Add(new Lectures(100, "Dr. Smith","Tech Talk", "Latest in AI", "April 10", "10:00 AM", addressLecture1));
        events.Add(new Lectures(500, "Micky Mouse", "Rags to Riches", "Mr. Mouse shares his experance of starting a busness", "Oct 5", "5:00 PM", addressLecture2));
        events.Add(new Receptions( "rsvp@example.com", "Networking Night", "Meet professionals", "April 12", "6:00 PM", addressReception1));
        events.Add(new Receptions("MarrageTimeRSVP", "Bringhurt's Recption", "Come Celibrate with us", "May 18", "2:00 PM", addressReception2));
        events.Add(new OutdoorGatherings("Sunny", "Community Picnic", "Food and fun outdoors", "April 15", "12:00 PM", addressOutdoorGathering1));
        events.Add(new OutdoorGatherings("Rainy", "Park Day", "Park day is a day where we can play at the park let us do it", "April 4", "10:00 AM", addressOutdoorGathering2));

        foreach (Event e in events)
        {
            Console.WriteLine("----- STANDARD DETAILS -----");
            Console.WriteLine(e.GetStandardDetails());

            Console.WriteLine("\n----- FULL DETAILS -----");

            if (e is Lectures lecture)
                Console.WriteLine(lecture.GetFullDetails());
            else if (e is Receptions reception)
                Console.WriteLine(reception.GetFullDetails());
            else if (e is OutdoorGatherings outdoor)
                Console.WriteLine(outdoor.GetFullDetails());

            Console.WriteLine("\n----- SHORT DESCRIPTION -----");

            if (e is Lectures lecture2)
                Console.WriteLine(lecture2.GetShortDetails());
            else if (e is Receptions reception2)
                Console.WriteLine(reception2.GetShortDetails());
            else if (e is OutdoorGatherings outdoor2)
                Console.WriteLine(outdoor2.GetShortDetails());

            Console.WriteLine("\n============================\n");
        }
    }
}