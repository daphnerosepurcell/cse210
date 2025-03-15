class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string desc, int points, bool completed = false) 
        : base(name, desc, points)
    {
        _completed = completed;
    }

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

    public override string SaveString() =>
        $"SimpleGoal|{_name}|{_desc}|{_points}|{_completed}";
}
