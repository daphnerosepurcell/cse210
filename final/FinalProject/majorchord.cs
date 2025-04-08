    class MajorChord : Chord
    {
        public MajorChord(string rootNote) : base(rootNote) { }

        public override void Build()
        {
            _notes.Clear();
            _notes.Add(_root);
            _notes.Add(Step(4));
            _notes.Add(Step(7));
        }
    }