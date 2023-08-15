public class SortingAlgo
{
    public static int[] BubbleSort(int[] array) {
    // Write your code here.
    var isSorted =  false;

    while (!isSorted)
    {
        isSorted = true;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                 (array[i + 1], array[i]) = (array[i], array[i + 1]);
                 isSorted = false; 
            }
        }
    }
    return array;
  }
}