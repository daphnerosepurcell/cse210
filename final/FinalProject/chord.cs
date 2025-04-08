   abstract class Chord
    {
        protected string root;
        protected List<string> notes = new List<string>();

        protected static List<string> scale = new List<string>()
        {
            "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
        };

        public Chord(string rootNote)
        {
            root = rootNote;
        }

        protected string Step(int interval)
        {
            int i = scale.IndexOf(root);
            return scale[(i + interval) % scale.Count];
        }

        public abstract void Build();

        public List<string> GetNotes()
        {
            return notes;
        }
    }