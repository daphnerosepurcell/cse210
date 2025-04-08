    public class Scale
    {
        public string Key { get; set; }
        public List<string> Notes { get; set; } = new();

        private static readonly string[] majorSteps = { "W", "W", "H", "W", "W", "W", "H" };
        private static readonly List<string> chromatic = new()
        {
            "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
        };

        public Scale(string key)
        {
            Key = key;
            Build();
        }

        public void Build()
        {
            int index = chromatic.IndexOf(Key);
            Notes.Add(Key);

            foreach (var step in majorSteps)
            {
                index += step == "W" ? 2 : 1;
                Notes.Add(chromatic[index % chromatic.Count]);
            }
        }

        public void DisplayScale()
        {
            Console.WriteLine($"Major Scale for {Key}: {string.Join(", ", Notes)}");
        }
    }
