    class AugmentedChord : Chord
    {
        public AugmentedChord(string rootNote) : base(rootNote) { }

        public override void Build()
        {
            _notes.Clear();
            _notes.Add(_root);
            _notes.Add(Step(4));
            _notes.Add(Step(8));
        }
    }
