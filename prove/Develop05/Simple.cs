using System;
class Simple : Goal
{
    private bool _checked = false;
    private bool _completed = false;
    public Simple(string goalName, string goalDescription, int goalPoints, bool checkedGoal = false) : base(goalName, goalDescription, goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _checked = checkedGoal;
    }
    public override string GetInformation()
    {
        {
            if (_checked)
            {
                _completed = true;
                return "[X] " + _goalName + " (" + _goalDescription + ")";
            }
            else
            {
                return "[ ] " + _goalName + " (" + _goalDescription + ")";
            }
        }
    }
    public override int GoalCompleted(int userPoints)
    {
        bool completed = _completed;

        _checked = true;
        if (completed == false)
        {
            GetInformation();
            userPoints = userPoints + _goalPoints;
            completed = true;
            return userPoints;
        }
        else
        {
            GetInformation();
            return userPoints;
        }

    }
    public override string GetString()
    {
        return "SimpleGoal:" + _goalName + "," + _goalDescription + "," + _goalPoints + "," + _checked;
    }
}
