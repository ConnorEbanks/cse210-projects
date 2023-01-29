using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        RandomPromptGenerator prompt = new RandomPromptGenerator();
        Entry theEntry = new Entry();
        Journal theJournal = new Journal();

        Console.WriteLine("\nWelcome to the Journal program! \n");

        string choice = "";

        while (choice != "5")
        {

            DisplayMenu();
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {

                // Display prompt
                prompt.DisplayPrompt();

                // Get users entry
                string response = Console.ReadLine();

                // Get date and save it as a string
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();  

                // Create the entry object
                theEntry._date = date;
                theEntry._randomPrompt = prompt.ToString();
                theEntry._response = response;

                
                theJournal._entries.Add(theEntry); 
            }
            else if (choice == "2")
            {
                theJournal.Display();
            }
            else if (choice == "3")
            {
                Console.Write("\nWhat is the file name? ");
                string file = Console.ReadLine();

                theJournal.Load(file);
            }
            else if (choice == "4")
            {
                Console.Write("\nWhat is the file name? ");
                string file = Console.ReadLine();

                theJournal.Save(file);
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease select one of the following choices: \n");
        Console.WriteLine("1. Write a new journal entry ");
        Console.WriteLine("2. Display all journal entries ");
        Console.WriteLine("3. Load journal entries ");
        Console.WriteLine("4. Save journal entry ");
        Console.WriteLine("5. Quit the program \n");
    }
}