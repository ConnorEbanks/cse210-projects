public class Entry
{

    public string _date;
    public string _randomPrompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} {_randomPrompt}:\n {_response}\n");
    }
}