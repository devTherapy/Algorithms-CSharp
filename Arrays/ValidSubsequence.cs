public static class ValidSubsequence
 {

    public static bool IsValidSubsequence(List<int> array, List<int> sequence) 
    {
      var arrayPointer = 0;
      var sequencePointer = 0;

      while (arrayPointer < array.Count && sequencePointer < sequence.Count)
      {
        
        if (array[arrayPointer] == sequence[sequencePointer])
        {
            sequencePointer++;
        }

        arrayPointer++;
      }

      return sequence.Count == sequencePointer;
	}
 }