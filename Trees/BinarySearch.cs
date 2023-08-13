public class BinarySearchAlgo{
     public static int BinarySearch(int[] array, int target) {
       // Write your code here.
       int leftPointer = array[0];
       int rightPointer =  array[^1];

       if(array[leftPointer] == target){
         return leftPointer;
        }

       if (array[rightPointer] == target)
        {
            return rightPointer;
        }

       while (leftPointer < rightPointer)
       {
            var midPointer = (int) Math.Floor((double) leftPointer + rightPointer / 2);
            
            if (array[midPointer] == target)
            {
                return array[midPointer];
            }
            if(array[midPointer] < target){
                leftPointer = midPointer++;
            }

            if (array[midPointer] > target)
            {
                rightPointer = midPointer--;
            }
       }    
       return -1;
  }
}