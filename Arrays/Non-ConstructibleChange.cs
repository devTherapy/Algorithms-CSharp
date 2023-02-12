public static class NonConstructibleChangeAlgo
{
    public static int NonConstructibleChange(int[] coins) 
    {

        var change = 0;

        if (coins.Length == 0 || coins[0] > 1)
        {
            return 1;
        }
        for (int i = 0; i < coins.Length; i++)
        {
            if (coins[0] > change + 1)
                return change + 1;
                change += coins[0];
        }
		return -1;
	}
}