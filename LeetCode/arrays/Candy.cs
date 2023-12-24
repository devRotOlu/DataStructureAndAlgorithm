namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class Candy
    {
        static public int MinimumCandy(int[] ratings)
        {
            var candyCount = 0;
            var biggerRatingCount = 0;
            var smallerRatingCount = 0;
            var length = ratings.Length - 1;
            for (int i = 0; i < length; i++)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    candyCount += 2 + biggerRatingCount++;
                    smallerRatingCount = 0;
                }
                    
                if (ratings[i] < ratings[i + 1])
                {
                    candyCount += 1 + smallerRatingCount++;
                    biggerRatingCount = 0;
                }

                if (ratings[i] == ratings[i + 1])
                {
                    candyCount += 1 + biggerRatingCount + smallerRatingCount;
                    biggerRatingCount = 0;
                    smallerRatingCount = 0;
                }
            }

            if (smallerRatingCount != 0)
                candyCount += 1 + smallerRatingCount;
            else candyCount += 1;

            return candyCount;
        }
    }
}
