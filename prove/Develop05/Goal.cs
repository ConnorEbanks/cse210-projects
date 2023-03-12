public abstract class Goal
{
    private string _name;
    private string _description;

    private int _pointsForRecording;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _pointsForRecording = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDisplayString();

    }