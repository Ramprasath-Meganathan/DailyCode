using System.Collections.Generic;
using System;
using System.Linq;

public class TournamentWinnerWithoutLinq {
  // O(n) time and O(n) space
  public string TournamentWinner(
    List<List<string> > competitions, List<int> results
  ) {
    string winner = "";
    string homeTeam = "";
    string awayTeam = "";
    string currentBest = "";
    Dictionary<string,int> pointsDict = new Dictionary<string,int>();
    pointsDict[currentBest] = 0;
    for(int i=0; i < competitions.Count; i++)
    {
        string[] competitionsArray = competitions[i].ToArray();
        homeTeam = competitionsArray[0]; awayTeam  = competitionsArray[1];
        winner = results[i] == 0 ? awayTeam : homeTeam;
        if(pointsDict.TryGetValue(winner, out int points))
        {
            pointsDict[winner] = points + 3;
        }
        else
        {
            pointsDict[winner] = 3;
        }
        if(pointsDict[winner] > pointsDict[currentBest])
            currentBest = winner;
    }
    return currentBest;
  }
}
