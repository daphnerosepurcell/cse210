   class AugmentedChord : Chord
    {
        public AugmentedChord(string rootNote) : base(rootNote) { }

        public override void Build()
        {
            notes.Clear();
            notes.Add(root);
            notes.Add(Step(4));
            notes.Add(Step(8));
        }
    }
