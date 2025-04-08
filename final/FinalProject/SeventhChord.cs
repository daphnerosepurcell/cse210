    class SeventhChord : Chord
    {
        public SeventhChord(string rootNote) : base(rootNote) { }

        public override void Build()
        {
            notes.Clear();
            notes.Add(root);
            notes.Add(Step(4));
            notes.Add(Step(7));
            notes.Add(Step(10));
        }
    }