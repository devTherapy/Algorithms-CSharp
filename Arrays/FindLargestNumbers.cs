public class FindLargestNumberAlgo{
 public static int[] FindThreeLargestNumbers(int[] array) {
    // Write your code here.
   // var returnArray = new int[3]{int.MinValue, int.MinValue, int.MinValue};
    int max = int.MinValue, mid = int.MinValue, min = int.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            min = mid;
            mid = max;
            max = array[i];
        }

        else if (array[i] > mid)
        {
            min = mid;
            mid = array[i];
        }

        else if (array[i] > min)
        {
            min = array[i];
        }
    }
        
    return new int[] {min, mid, max};
  }
}