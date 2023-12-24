namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class StockII
    {
        static public int MaxProfit(int[] prices)
        {
            int profit = 0;
            var purchaseIndex = -1;
            var salesIndex = -1;

            for (int i = 0; i < (prices.Length - 1); i++)
            {
                if (prices[i] < prices[i + 1] && purchaseIndex < 0)
                {
                    purchaseIndex = i;
                    salesIndex = i + 1;
                }
                else if(prices[i] < prices[i + 1] && purchaseIndex >= 0)
                {
                    salesIndex = i + 1;
                }
                   
                if (prices[i + 1] < prices[i] && purchaseIndex >= 0)
                {
                    profit += prices[salesIndex] - prices[purchaseIndex];
                    purchaseIndex = -1;
                }      
            }

            if (purchaseIndex != -1)
                profit += prices[salesIndex] - prices[purchaseIndex];

            return profit;
        } 
    }
}
