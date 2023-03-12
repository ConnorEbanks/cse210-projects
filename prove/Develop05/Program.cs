using System;

class Program
{
    static void Main(string[] args)
    {

        string choice = "";

        string secondaryChoice = "";

        string goalName = "";

        string shortDescription = "";

        int points = 0;

        string addPoints = "";


        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine($"You have {points} points.\n");
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                DisplayWhichGoal();
                Console.Write("Which type of goal would you like to create? ");
                secondaryChoice = Console.ReadLine();

                if (choice == "1")
                {
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("What is the short description of it? ");
                shortDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with it? ");
                addPoints = Console.ReadLine();
                }
                else if (choice == "2")
                {
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("What is the short description of it? ");
                shortDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with it? ");
                addPoints = Console.ReadLine();
                }
                else if (choice == "3")
                {
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("What is the short description of it? ");
                shortDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with it? ");
                addPoints = Console.ReadLine();
                }
            }
        }
        static void DisplayMenu()
            {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            }
        static void DisplayWhichGoal()
            {
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("1. Simple Goal ");
                Console.WriteLine("2. Eternal Goal ");
                Console.WriteLine("3. Checklist Goal ");
            }
    }
}