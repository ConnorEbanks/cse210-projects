using System;

class Program
{

    static void Main(string[] args)
    {
        string userInput = "";


        Reference theReference = new Reference("John", 3, 16);
        string text = "For God so loved the world...";
        Scripture theScripture = new Scripture(theReference, text);

        string refer = theReference.GetReferenceText();
        string scrip = theScripture.GetDisplayText();
        Console.WriteLine($"{refer}: {scrip}");

        while (userInput != "quit")
        {
            WelcomeMessage();
            userInput = Console.ReadLine();
            Console.Clear();
        }

        static void WelcomeMessage()
        {
            Console.Write("\nWelcome to the scripture Memorizer game, press enter to hide words, or type 'quit' to end the game. ");
        }
    }
}