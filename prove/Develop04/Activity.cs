public class Activity
{
    private string _activityWelcome;
    private string _activityDescription;

    public Activity(string welcome, string description)
    {
        _activityDescription = description;
        _activityWelcome = welcome;
    }

    public string GetWelcome()
    {
        return _activityWelcome;
    }

    public string GetDescription()
    {
        return _activityDescription;
    }

    }