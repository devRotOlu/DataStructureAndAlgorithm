namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class StockIV_188
    {
        static public int MaxProfit(int[] prices,int trans)
        {
            var profit = new int[trans];
            var purchaseIndex = -1;
            var salesIndex = -1;
            var count = 0;

            for (int i = 0; i < (prices.Length - 1); i++)
            {
                if (prices[i] < prices[i + 1] && purchaseIndex < 0)
                {
                    purchaseIndex = i;
                    salesIndex = i + 1;
                }
                else if (prices[i] < prices[i + 1] && purchaseIndex >= 0)
                {
                    salesIndex = i + 1;
                }

                if (prices[i + 1] < prices[i] && purchaseIndex >= 0)
                {
                    if (profit[count] < prices[salesIndex] - prices[purchaseIndex])
                        profit[count] = prices[salesIndex] - prices[purchaseIndex];
                    else
                        profit[++count] = prices[salesIndex] - prices[purchaseIndex];
                    purchaseIndex = -1;
                }

                if (count == (trans - 1)) break;

            }

            if (purchaseIndex != -1)
            {
                if (profit[count] < prices[salesIndex] - prices[purchaseIndex])
                    profit[count] = prices[salesIndex] - prices[purchaseIndex];
                else if (count < 1)
                    profit[++count] = prices[salesIndex] - prices[purchaseIndex];
            }

            int _profit = 0;

            foreach (var item in profit)
                _profit += item;

            return _profit;
        }
    }
}
