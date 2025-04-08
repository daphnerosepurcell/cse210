    static class ChordFactory
    {
        public static Chord GetChord(string type, string root)
        {
            if (string.IsNullOrEmpty(root)) return null;

            switch (type)
            {
                case "major":
                    return new MajorChord(root);
                case "minor":
                    return new MinorChord(root);
                case "diminished":
                    return new DiminishedChord(root);
                case "augmented":
                    return new AugmentedChord(root);
                case "seventh":
                    return new SeventhChord(root);
                default:
                    return null;
            }
        }
    }
