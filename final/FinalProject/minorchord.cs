   class MinorChord : Chord
    {
        public MinorChord(string rootNote) : base(rootNote) { }

        public override void Build()
        {
            notes.Clear();
            notes.Add(root);
            notes.Add(Step(3));
            notes.Add(Step(7));
        }
    }
