using System.Collections;

public static class TournamentWinnerAlgo
{
    public static string TournamentWinner(List<List<string> > competitions, List<int> results) 
    {
		// Write your code here.
         var Hashtable = new Dictionary<string, int>();
         string winner = string.Empty;
         int maxScore = 0;
        for (int i = 0; i < competitions.Count; i++)
        {
            var duo = competitions[i];
            var roundWinner = results[i] == 0 ? duo[1] : duo[0];
            int value = 0;
            if (Hashtable.ContainsKey(roundWinner))
            {
                value = Hashtable[roundWinner] += 3;

            
            }

            else
            {
                value = Hashtable[roundWinner] = 3;
             
            }

            if (value > maxScore)
            {
                maxScore = value;
                winner = roundWinner;
            }
        }
		return winner;
	}
}