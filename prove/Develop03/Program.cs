using System;
using System.Data;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Reference myReference = new Reference("John", 3, 16);

        string verse = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        string[] splitStrings = verse.Split();

        List<Word> words=[];
        foreach(string verseString in splitStrings)
        {
            Word verseWord = new Word(verseString);
            words.Add(verseWord);
        }
        Scripture myScripture = new Scripture(words, myReference);

        bool done = false;

        while (!done)
        {
            Console.Clear();
            Console.WriteLine("Press enter to contine or type 'q' to quite.\n");

            myScripture.PrintText();
            done = myScripture.HideWords();

            string stop = Console.ReadLine();
            if (stop == "q")
            {
                done = true;
            }
        }
    }
}