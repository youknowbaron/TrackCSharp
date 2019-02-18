using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _list;

    public HighScores(List<int> list)
    {
        this._list = list;
    }

    public List<int> Scores()
    {
        return _list;
    }

    public int Latest()
    {
        return _list[_list.Count - 1];
    }

    public int PersonalBest()
    {
        var max = _list[0];
        foreach (var value in _list)
        {
            if (value > max)
                max = value;
        }

        return max;
    }

    public List<int> PersonalTop()
    {
        var topList = new List<int>();
        foreach (var value in _list)
        {
            if (topList.Count != 0 && value > topList[0])
                topList.Insert(0, value);
            else if (topList.Count >= 2 && value > topList[1])
                topList.Insert(1, value);
            else if (topList.Count == 3 && value > topList[2])
                topList.Insert(2, value);
            else if (topList.Count <= 3)
                topList.Add(value);
            if (topList.Count == 4)
                topList.RemoveAt(3);
        }

        return topList;
    }

    public string Report()
    {
        var lastScore = _list[_list.Count - 1];
        var bestScore = PersonalBest();
        if (lastScore == bestScore)
            return "Your latest score was " + lastScore + ". That's your personal best!";
        if (lastScore < bestScore)
            return "Your latest score was " + lastScore + ". That's " + (bestScore - lastScore) + " short of your personal best!";
        return "";
    }
}