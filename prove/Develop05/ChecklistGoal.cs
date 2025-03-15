class ChecklistGoal : Goal
{
    private int _required;
    private int _completed;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int required, int bonus, int completed = 0)
        : base(name, desc, points)
    {
        _required = required;
        _bonus = bonus;
        _completed = completed;
    }

    public override int RecordEvent()
    {
        if (_completed < _required)
        {
            _completed++;
            if (_completed == _required)
            {
                Console.WriteLine("Checklist goal complete! Bonus awarded.");
                return _points + _bonus;
            }
            return _points;
        }
        Console.WriteLine("Goal already completed.");
        return 0;
    }

    public override bool IsComplete() => _completed >= _required;

    public override string SaveString() =>
        $"ChecklistGoal|{_name}|{_desc}|{_points}|{_required}|{_bonus}|{_completed}";

    public override string Display() =>
        $"[{(IsComplete() ? 'X' : ' ')}] {_name} ({_desc}) Completed: {_completed}/{_required}";
}