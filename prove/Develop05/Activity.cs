using System.Diagnostics;

public class Activity
{
    string _startMessage;
    string _endMessage;
    string _name;
    string _description;
    int _duration;

    

        public void StartMessage(string _startMessage)
    {
        Console.WriteLine (_startMessage);
    }
    public void DisplayEndMessage(string _endMessage)
    {
        Console.WriteLine (_endMessage);
    }
    
    
    
}