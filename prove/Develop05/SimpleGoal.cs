class SimpleGoal : Goal
{
    private bool _completed = false;

    public SimpleGoal(string name, string desc, int points) : base(name, desc, points) { }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return _points;
        }
        Console.WriteLine("Goal already completed.");
        return 0;
    }

    public override bool IsComplete() => _completed;
}