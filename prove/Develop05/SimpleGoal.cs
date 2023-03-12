public class SimpleGoal : Goal
{
    private bool _complete;

    public SimpleGoal(string name, string description, int points, bool complete)
        : base(name, description, points)
    {
        _complete = complete;
    }


    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        return _complete;
    }

    public override string GetDisplayString()
    {
        throw new NotImplementedException();
    }
}