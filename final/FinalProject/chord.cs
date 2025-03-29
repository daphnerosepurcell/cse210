public abstract class Chord
{
    public string RootNote { get; protected set; }
    public List<string> Notes { get; protected set; } = new List<string>();

    public Chord(string rootNote)
    {
        RootNote = rootNote;
    }

    public abstract void BuildChord();
}