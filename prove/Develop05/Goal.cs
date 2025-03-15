abstract class Goal
{
    protected string _name;
    protected string _desc;
    protected int _points;

    public Goal(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();

    public virtual string Display()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {_name}: {_desc}";
    }
}