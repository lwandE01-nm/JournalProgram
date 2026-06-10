public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        _score += _goals[index].RecordEvent();
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatusString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score}");
    }
}
