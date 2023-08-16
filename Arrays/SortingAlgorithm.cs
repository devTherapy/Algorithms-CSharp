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

    public static int[] InsertionSort(int[] array) {
    // Write your code here.
    for (int i = 1; i < array.Length; i++)
    {
        var j = i;
        while (j > 0 && array[j] < array[j - 1])
        {
                (array[j], array[j - 1]) = (array[j - 1], array[j]);
                j--;        
        }
    }
    return array;
  }

   public static int[] SelectionSort(int[] array)
    {
         // Write your code here.
         for (int i = 0; i < array.Length - 1; i++)
         {
            var minIndex = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            (array[minIndex], array[i]) = (array[i], array[minIndex]);
        }
        return array;
    }
}