using System.IO;
using System.Net.Http.Headers;


class GoalManager
{
    private string _fileName;
    private List<CreateGoal> _goals = new List<CreateGoal>(); 



    public GoalManager()
    {
        
    }


    /*public virtual void SaveGoal(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var g in saveGoals)
            {
                outputFile.WriteLine(g);
            }
        }
    }*/
}