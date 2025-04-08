    class MinorChord : Chord
    {
        public MinorChord(string rootNote) : base(rootNote) { }

        public override void Build()
        {
            _notes.Clear();
            _notes.Add(_root);
            _notes.Add(Step(3));
            _notes.Add(Step(7));
        }
    }