public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you remember this experience in the future?"
    };

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {_prompts[random.Next(_prompts.Count)]} ---");

        Console.WriteLine("\nWhen you have something in mind press Enter.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder each question:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n> {_questions[random.Next(_questions.Count)]}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
