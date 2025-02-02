public class Prompt
{
    private List<string> _prompts;
    private Random random = new Random(); 

    public Prompt()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned today?",
            "What is one thing I accomplished today that I'm proud of?",
            "Who is someone I am grateful for today, and why?",
            "What was the most challenging part of my day, and how did I handle it?",
            "If I could give advice to my future self based on today, what would it be?"
        };
    }

    public string GetRandom()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}