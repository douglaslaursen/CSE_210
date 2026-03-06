using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); 

        Menu menu = new Menu();
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
                Console.WriteLine("");
                Entry entry = new Entry();
                entry.CreateEntry();
                journal.AddEntry(entry);
                break;

                case 2:
                // Display Journal Entries
                Console.WriteLine("");
                foreach (Entry entry1 in journal.entries)
                {
                    entry1.displayResponse();
                }
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadLine();
                break;

                case 3:
                // Save journal to file
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();

                journal.WriteToFile(saveFile);

                Console.WriteLine("Journal saved!");
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadLine();
                break;

                case 4:
                // Load journal from file
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();

                journal.ReadFromFile(loadFile);

                Console.WriteLine("Journal loaded!");
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadLine();
                break;

                case 5:
                // Share Scripture
                Entry scripture = new Entry();
                Console.WriteLine("");
                scripture.DisplayScripture();
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadLine();
                break;

                case 6:
                    done = true;
                    break;
            
            }
        } while (!done);
    }
}