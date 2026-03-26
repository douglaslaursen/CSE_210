using System;

class Program
{
    static void Main(string[] args)
    {
        Goals TotalScore = new Goals();
        TotalScore.DisplayScore();

        Menu menu = new Menu();
        menu.DisplayMainMenu();
    }
}