using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goals> _goals = new List<Goals>();
    private int _score;



    public void CreateGoal()
    {
        Console.Write("The  types of Goals are:\n 1. Simple Goal.\n 2. Eternal Goal.\n 3. Checklist Goal\n Which type of goal would you like to create? ");
        string option = Console.ReadLine();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        if (option == "1")
        {
            SimpleGoals simpleGoal = new SimpleGoals(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (option == "2")
        {
            EternalGoals eternalGoal = new EternalGoals(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (option == "3")
        {
            Console.Write("Enter how many times this goal needs to be accomplished: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter the bonus points upon full completion: ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoals checklistGoal = new ChecklistGoals(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Invalid goal type selected.");
        }

        Console.WriteLine("Goal created successfully!\n");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\n No goals have been created yet.");
            return;
        }

        Console.WriteLine("\n Your goals are:");
        int index = 1;

        foreach (Goals goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetails()}");
            index++;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("CThe current Goals:");
        for (int i = 0; i < _goals.Count; i++) //Go along the list
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        Console.Write("Choice what Goal update: ");
        bool isNumber = int.TryParse(Console.ReadLine(), out int number);


        if (isNumber && number >= 1 && number <= _goals.Count)
        {
            Goals selectedGoal = _goals[number - 1];
            int pointsEarned = selectedGoal.RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
            Console.WriteLine($"Total Score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }


    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Save the total score first
            writer.WriteLine(_score);

            foreach (Goals goal in _goals)
            {
                if (goal is SimpleGoals sg)
                {
                    writer.WriteLine($"SimpleGoal|{sg.GetName()}|{sg.GetDescription()}|{sg.GetPoints()}|{sg.GetIsComplete()}");
                }
                else if (goal is EternalGoals eg)
                {
                    writer.WriteLine($"EternalGoal|{eg.GetName()}|{eg.GetDescription()}|{eg.GetPoints()}");
                }
                else if (goal is ChecklistGoals cg)
                {
                    writer.WriteLine($"ChecklistGoal|{cg.GetName()}|{cg.GetDescription()}|{cg.GetPoints()}|{cg.GetTimesCompleted()}|{cg.GetTarget()}|{cg.GetBonusPoints()}");
                }
            }
        }

        Console.WriteLine("\nGoals saved successfully.\n");
    }


    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        // Clear existing goals
        _goals.Clear();

        // Load total score from the first line
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoals sg = new SimpleGoals(name, description, points);
                sg.SetIsComplete(isComplete);
                _goals.Add(sg);
            }
            else if (type == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoals eg = new EternalGoals(name, description, points);
                _goals.Add(eg);
            }
            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int timesCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoals cg = new ChecklistGoals(name, description, points, target, bonus);
                cg.SetTimesCompleted(timesCompleted);
                _goals.Add(cg);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
    






}