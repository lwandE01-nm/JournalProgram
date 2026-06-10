using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("      ETERNAL QUEST PROGRAM      ");
            Console.WriteLine("=================================\n");

            manager.DisplayScore();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    Console.Clear();
                    manager.DisplayGoals();
                    Pause();
                    break;

                case "3":
                    RecordEvent(manager);
                    break;

                case "4":
                    Console.Write("Enter filename to save (e.g. goals.txt): ");
                    string saveFile = Console.ReadLine();
                    manager.Save(saveFile);
                    Console.WriteLine("Goals saved successfully!");
                    Pause();
                    break;

                case "5":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manager.Load(loadFile);
                    Console.WriteLine("Goals loaded successfully!");
                    Pause();
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    Pause();
                    break;
            }
        }
    }

    // ---------------- CREATE GOAL ----------------
    static void CreateGoal(GoalManager manager)
    {
        Console.Clear();
        Console.WriteLine("Choose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("\nEnter choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            manager.AddGoal(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            manager.AddGoal(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times to complete? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points on completion: ");
            int bonus = int.Parse(Console.ReadLine());

            manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
            Pause();
        }
    }

    // ---------------- RECORD EVENT ----------------
    static void RecordEvent(GoalManager manager)
    {
        Console.Clear();
        Console.WriteLine("Which goal did you complete?\n");

        manager.DisplayGoals();

        Console.Write("\nEnter goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        manager.RecordEvent(index);

        Console.WriteLine("\nEvent recorded! Points awarded.");
        Pause();
    }

    // ---------------- PAUSE ----------------
    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}
