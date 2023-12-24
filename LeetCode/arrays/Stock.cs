namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class Stock
    {
        static public int MaxProfit(int[] prices)
        {
            var purchasePriceIndex = 0;
            var salesPriceIndex = 1;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i + 1] > prices[salesPriceIndex])
                    salesPriceIndex = i + 1;
                if (prices[i] < prices[purchasePriceIndex] && salesPriceIndex > i)
                    purchasePriceIndex = i; 
            }

            if (prices[salesPriceIndex] <= prices[purchasePriceIndex])
                return 0;

            return prices[salesPriceIndex] - prices[purchasePriceIndex];
        }
    }
}

