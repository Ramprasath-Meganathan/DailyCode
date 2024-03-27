using System.Collections.Generic;
using System;
using System.Linq;

public class TournamentProblem {
  public string TournamentWinner(
    List<List<string> > competitions, List<int> results
  ) {
    string winner = "";
    string homeTeam = "";
    string awayTeam = "";
    Dictionary<string,int> pointsDict = new Dictionary<string,int>();
    for(int i=0; i < competitions.Count; i++)
    {
        string[] competitionsArray = competitions[i].ToArray();
        homeTeam = competitionsArray[0]; awayTeam  = competitionsArray[1];
        if(results[i] == 0)
            winner = awayTeam;
        else
            winner = homeTeam;
        if(pointsDict.ContainsKey(winner))
        {
            pointsDict[winner] = pointsDict[winner] + 3;
        }
        else
        {
            pointsDict[winner] = 3;
        }
    }
    return pointsDict.First(x=>x.Value == pointsDict.Values.Max()).Key;
  }
}
