public static class SortedSquare
{
    public static int[] SortedSquaredArray(int[] array) 
    {
        var returnArr = new int[array.Length];

        var firstIndex = 0;
        var lastIndex = array.Length - 1;
        var counter = array.Length - 1;
        for (int i = 0; i < array.Length; i++)
        {
            if(Math.Abs(array[firstIndex]) >  Math.Abs(lastIndex))
            {
               returnArr[counter - i] = array[firstIndex] * array[firstIndex];
               firstIndex++;
            }
            else
            {
               returnArr[counter - i] = array[lastIndex] * array[lastIndex];
               lastIndex--;
            }
        }

		// Write your code here.
		return returnArr;
	}
}