namespace Integers;
public class Integers
{
    /// <summary>
    /// Get Nth Fibonacci
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
     public static int GetNthFib(int n) //n =6 expect 5
     {
        //011235
        int previous = 0, current = 1;

        for (int i = 0; i < n -1; i++)
        {
            (previous, current) = (current, previous + current);
        }
        // Write your code here.
        return previous;
     }
     public static int GetNthFibRecursive(int n) //n =6 expect 5
     {
        //011235
        if(n <= 2) return n-1;
        return GetNthFibRecursive(n - 1) + GetNthFibRecursive(n - 2);
        //recursive steps
        //a GetNthFibRecursive(6 - 1)  3
        //b GetNthFibRecursive(5 - 1) 2
        //c GetNthFibRecursive(4 - 1) 1
        //d GetNthFibRecursive(3 - 1)  1   -- = 1
        //e GetNthFibRecursive(3 - 2) 0
        //f GetNthFibRecursive(4 - 2) 1
        //g GetNthFibRecursive(5 - 2) 1
        //h GetNthFibRecursive(6 - 2) 2

        // -> a + h = 5
     }
}
