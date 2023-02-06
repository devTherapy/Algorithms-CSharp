using System.Collections;
public static class Arrays
{
  //0(N) tc, 0(N) sc
  public static int[] TwoSum(int[] array, int target)
  {

    Hashtable Hashtable = new Hashtable();

    for (int i = 0; i < array.Length; i++)
    {
        var diff = target - array[i];

        if (Hashtable.ContainsKey(diff))
        {
            return new int[]{array[i], diff};
        }

        Hashtable.Add(array[i], true);
        
    }
        return new int[]{};
  }

//0(NlogN) tc  => because of the sorting, 0(1) sc
    public static int[] TwoSum2(int[] array, int targetSum)
  {
     Array.Sort<int>(array);
     var leftPointer = 0;
     var rightPointer = array.Length - 1;

     while (leftPointer < rightPointer)
     {
        var currentSum = array[leftPointer] + array[rightPointer];

        if (currentSum == targetSum)
        {
            return new int[]{leftPointer, rightPointer};
        }
        else if(currentSum < targetSum)
        {
           leftPointer++;
        }    
         else
         {
            rightPointer--;
         }

     }

     return new int[]{};
  }
}