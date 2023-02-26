public class Breathing : Activity
{
    private string _breatheIn;
    private string _breatheOut;

    public Breathing(string welcome, string description, string breatheIn, string breatheOut)
        : base(welcome, description)
    {
        _breatheIn = breatheIn;
        _breatheOut = breatheOut;
    }

    public string GetBreatheIn()
    {
        return $"{_breatheIn}...";
    }
    public string GetBreatheOut()
    {
        return $"{_breatheOut}...";
    }
}