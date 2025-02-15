class Scripture
{
    private ScriptureReference reference;
    private List<Word> words;
    private Random random = new Random();

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(reference.ToString());
        Console.WriteLine(string.Join(" ", words));
    }

    public void HideWords()
    {
        var visibleWords = words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count == 0) return;
        
        int hideCount = Math.Min(3, visibleWords.Count);
        for (int i = 0; i < hideCount; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsFullyHidden()
    {
        return words.All(w => w.IsHidden());
    }
}