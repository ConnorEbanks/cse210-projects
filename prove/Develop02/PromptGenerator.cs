public class RandomPromptGenerator
{
    String[] _randomPrompt = new String[] {"\nWho was the most interesting person I interacted with today?\n", "\nWhat was the best part of my day?\n", "\nHow did I see the hand of the Lord in my life today?\n", "\nWhat was the strongest emotion I felt today?\n", "\nIf I had one thing I could do over today, what would it be?\n", "\nHow did I help someone feel the Savior's love today?\n", "\nWhat relationship can I strengthen this week?\n", "\nHow did I serve someone else today?\n"};

    public void DisplayPrompt()
    {
        var rnd = new Random();
        var randomIndex = rnd.Next(0, _randomPrompt.Length);
        Console.Write(_randomPrompt[randomIndex]);
        Console.Write("\n> ");
    }
}