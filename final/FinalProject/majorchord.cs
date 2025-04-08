  class MajorChord : Chord
    {
        public MajorChord(string rootNote) : base(rootNote) { }

        public override void Build()
        {
            notes.Clear();
            notes.Add(root);
            notes.Add(Step(4));
            notes.Add(Step(7));
        }
    }