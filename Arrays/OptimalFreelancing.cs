public class OptimalFreeLancingAlgo
{
   public int OptimalFreelancing(Dictionary<string, int>[] jobs)
    {
        var paymentsTaken = new int[7];
        var profit = 0;

        for (int i = 0; i < jobs.Length; i++)
        {
            var deadline = jobs[i]["deadline"];
            deadline = Math.Min(deadline, 7);
            var currentPayment = jobs[i]["payment"];

            for (int j = deadline - 1; j >= 0; j--)
            {
                //if we have taken a payment for an earlier job, check to see if this new payment is higher than what we have taken, 
                //if so, take that the new payment anf find somewhere else before the deadline to do the earlier job.
                if (paymentsTaken[j] < currentPayment && currentPayment != 0 )
                {
                    int tmp = paymentsTaken[j];
                    paymentsTaken[j] = currentPayment;
                    currentPayment = tmp;               
                 }
            }
        }
         return paymentsTaken.Sum();
    }
}