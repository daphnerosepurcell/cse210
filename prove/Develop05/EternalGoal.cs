class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points) : base(name, desc, points) { }

    public override int RecordEvent() => _points;
    public override bool IsComplete() => false;
}
