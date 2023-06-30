class Goal
{ 
    protected string _goalName;

    protected string _goalDescription;

    protected int _goalPoints;

    private bool _Completed  = false;

    public Goal(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    public string GetName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _goalDescription;
    }

    public void SetDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public int GetPoints()
    {
        return _goalPoints;
    }

    public void SetPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }
    public virtual string GetInformation()
    {
        return $"[] {_goalName} ({_goalDescription})";
    }
    public virtual int GoalCompleted(int totalPoints)
    {
        return totalPoints;
    }

    public virtual string GetString()
    {
        return "Goal:" + _goalName + "," + _goalDescription + "," + _goalPoints + "," + false;
    }
}