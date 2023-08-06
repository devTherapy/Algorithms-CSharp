public class MinimumWaitingTimeAlgo{
     public int MinimumWaitingTime(int[] queries) 
     {
          Array.Sort(queries);
          var totalWaitingTime = 0;
       // Write your code here.
          for (int i = 0; i < queries.Length; i++)
          {
               var duration = queries[i];
               var queriesLeft = queries.Length - (i + 1);
               totalWaitingTime += queriesLeft * duration;

          }
          return totalWaitingTime;
     }
}