class ChecklistGoal : Goal
{
    private int _requiredTimes;
    private int _bonus;
    private int _timesCompleted;

    public ChecklistGoal(string name, string desc, int points, int requiredTimes, int bonus)
        : base(name, desc, points)
    {
        _requiredTimes = requiredTimes;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _requiredTimes)
        {
            _timesCompleted++;
            if (_timesCompleted == _requiredTimes)
            {
                Console.WriteLine("Checklist Goal completed!");
                return _points + _bonus;
            }
            return _points;
        }
        Console.WriteLine("Goal already completed.");
        return 0;
    }

    public override bool IsComplete() => _timesCompleted >= _requiredTimes;

    public override string Display()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {_name}: {_desc} (Completed {_timesCompleted}/{_requiredTimes})";
    }
}