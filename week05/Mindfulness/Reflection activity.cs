using System;
using System.Collections.Generic;

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
        "How did you get started?",
        "What did you learn about yourself?",
        "How did you feel when it was complete?",
        "What could you learn from this experience?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");

        Console.WriteLine("\nWhen you have something in mind press Enter.");
        Console.ReadLine();

        Console.WriteLine("\nReflect on the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[_random.Next(_questions.Count)];

            Console.WriteLine($"\n> {question}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
