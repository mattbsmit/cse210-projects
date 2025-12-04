using System.IO;
using System.Net.Http.Headers;


class GoalManager
{
    string _goalType;
    string _name;
    string _description;
    int _points;
    bool _status;
    int _bonusPoints;
    int _completetions;
    private string saveString;


    List<string> saveGoals = new List<string>(); 


    public GoalManager()
    {
        
    }

    public GoalManager(string goalType, string name, string description, int points, bool status)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _status = status;
    }

    public GoalManager(string goalType, string name, string description, int points, int bonusPoints, int completetions, bool status)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _status = status;
        _bonusPoints = bonusPoints;
        _completetions = completetions;
    }

    public void SaveString()
    {
        saveString = ($"{_goalType}|{_name}|{_description}|{_points}|{_status}");
        saveGoals.Add(saveString);
    }

    public virtual void SaveGoal(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var g in saveGoals)
            {
                outputFile.WriteLine(g);
            }
        }
    }
}