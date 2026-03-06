using System;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> _entries = new List<Entry>{}; 

        Menu menu= new Menu();
        bool done = false;
        int userResponse;
        do
        {
            userResponse = menu.ProcessMenu();
            switch (userResponse)  //simular to if, else if code but cleaner
            {
                case 1:
                // Create new Journal Entry
                // Add entry to list of journal entries
                Entry entry = new Entry();
                entry.CreateEntry();
                _entries.Add(entry);
                break;

                case 2:
                // Display Journal Entries
                foreach(Entry entry1 in _entries)
                {
                    // Console.WriteLine(job);
                    entry1.displayResponse();
                }
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                break;
                case 3:
                // Save journal to file

                break;
                case 4:
                // Load journal from file

                break;
                case 5:
                    done = true;
                    break;
            
            }
        } while (!done);
    }
}