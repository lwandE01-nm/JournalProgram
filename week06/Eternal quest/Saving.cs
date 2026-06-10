public void Save(string filename)
{
    using (StreamWriter output = new StreamWriter(filename))
    {
        output.WriteLine(_score);

        foreach (Goal g in _goals)
        {
            output.WriteLine(g.GetSaveString());
        }
    }
  public void Load(string filename)
{
    string[] lines = File.ReadAllLines(filename);

    _score = int.Parse(lines[0]);
    _goals.Clear();

    for (int i = 1; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split('|');

        string type = parts[0];

        if (type == "SimpleGoal")
        {
            _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
        }
        else if (type == "EternalGoal")
        {
            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
        }
        else if (type == "ChecklistGoal")
        {
            ChecklistGoal g = new ChecklistGoal(
                parts[1],
                parts[2],
                int.Parse(parts[3]),
                int.Parse(parts[6]),
                int.Parse(parts[4])
            );

            _goals.Add(g);
        }
    }
}
}
