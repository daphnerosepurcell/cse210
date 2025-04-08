    class SeventhChord : Chord
    {
        public SeventhChord(string rootNote) : base(rootNote) { }

        public override void Build()
        {
            _notes.Clear();
            _notes.Add(_root);
            _notes.Add(Step(4));
            _notes.Add(Step(7));
            _notes.Add(Step(10));
        }
    }