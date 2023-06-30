using System;
class Eternal : Goal
{
    public Eternal(string goalName, string goalDescription, int goalPoints) : base(goalName, goalDescription, goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }
    public override string GetInformation()
    {
        return $"[ ] {_goalName} ({_goalDescription})";
    }
    public override int GoalCompleted(int totalPoints)
    {
        GetInformation();
        totalPoints = totalPoints + _goalPoints;
        return totalPoints;
    }
    public override string GetString()
    {
        return "EternalGoal:" + _goalName + "," + _goalDescription + "," + _goalPoints;
    }
}