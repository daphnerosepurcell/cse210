    abstract class Chord
    {
        protected string _root;
        protected List<string> _notes = new List<string>();

        protected static List<string> _scale = new List<string>()
        {
            "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
        };

        public Chord(string rootNote)
        {
            _root = rootNote;
        }

        protected string Step(int interval)
        {
            int index = _scale.IndexOf(_root);
            return _scale[(index + interval) % _scale.Count];
        }

        public abstract void Build();

        public List<string> GetNotes()
        {
            return _notes;
        }
    }