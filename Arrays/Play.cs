public static class Play 
{
    public static bool ValidSubsequence(List<int> array, List<int> sequence)
    {
        var sequencePointer = 0;
        var SubSequenceSequencePointer = 0;
        for ( int i = 0; sequencePointer < array.Count && SubSequenceSequencePointer < sequence.Count; i++)
        {
            if (array[i] == sequence[SubSequenceSequencePointer])
            {
                SubSequenceSequencePointer++;
            }
        }
        return SubSequenceSequencePointer == sequence.Count;
    }

    public static string TournamentWinner(List<List<string> > competitions, List<int> results) {
        
         var competitionWinner = string.Empty;
        var winnerDict = new Dictionary<string, int>();
        var maxScore = 0;
        for (int i = 0; i < competitions.Count; i++)
        {
            var competition = competitions[i];
            string? roundWinner = competition[results[i] == 0 ? 1 : 0];
            var score = 0;
            if (!winnerDict.ContainsKey(roundWinner))
            {
              score =  winnerDict[roundWinner] = 3;
            }
            else
            {
                score = winnerDict[roundWinner]+=3;
            }
            if (score > maxScore)
            {
                competitionWinner = roundWinner;
                maxScore = score;
            }
        }
		return "";
	}

    public static int NonConstructibleChange(int[] coins) {
        Array.Sort(coins);
        var change = 0;

        foreach (var coin in coins)
        {
            if (coin > change + 1)
            {
                return change + 1;
            }

            change += coin;
        }

        return change + 1;
    }



    
}

