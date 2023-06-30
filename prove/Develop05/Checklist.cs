using System;
class Checklist : Goal
{
    private int _currentlyCounter;
    private int _verificationCounter;
    private int _bonusCompleted;
    private bool _checked = false;

    public Checklist(string goalName, string goalDescription, int goalPoints, int verificationCounter, int bonusGoalCompleted, int currentCounter = 0, bool Goalchecked = false) : base(goalName, goalDescription, goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _verificationCounter = verificationCounter;
        _bonusCompleted = bonusGoalCompleted;
        _currentlyCounter = currentCounter;
        _checked = Goalchecked;
    }
    public int GetCounter()
    {
        return _verificationCounter;
    }
    public void SetCounter(int verificationCounterToSet)
    {
        _verificationCounter = verificationCounterToSet;
    }
    public int GetBonus()
    {
        return _bonusCompleted;
    }
    public void SetBonusGoalCompleted(int bonusGoalCompletedToSet)
    {
        _bonusCompleted = bonusGoalCompletedToSet;

    }
    public int GetCurrentlyCounter()
    {
        return _currentlyCounter;
    }
    public void SetCurrentlyCounter(int currenlyCounterToSet)
    {
        _currentlyCounter = currenlyCounterToSet;

    }
    public override string GetInformation()
    {
        if (_checked)
        {
            return $"[X] {_goalName} ({_goalDescription}) -- Currently completed {GetCurrentlyCounter()}/{_verificationCounter}";
        }
        else
        {
            return $"[ ] {_goalName} ({_goalDescription}) -- Currently completed {GetCurrentlyCounter()}/{_verificationCounter}";
        }
    }
    public override string GetString()
    {
        return "CheckListGoal:" + _goalName + "," + _goalDescription + "," + _goalPoints + "," + _verificationCounter + "," + _bonusCompleted + "," + _currentlyCounter;
    }
}