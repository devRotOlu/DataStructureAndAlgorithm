namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class InsertPosition
    {
        static public int Search(int[] numbers, int target)
        {

            return ModifiedBinarySearch(numbers, target);
        }

        static private int ModifiedBinarySearch(int[] items, int integer)
        {
            var lowerBound = 0;
            var upperBound = items.Length - 1;

            var index = -1;
            var diff = int.MaxValue;

            while (lowerBound <= upperBound)
            {
                var midPoint = (upperBound + lowerBound) / 2;
                if ((items[midPoint] - integer) >= 0 && (items[midPoint] - integer) <= diff)
                {
                    index = midPoint;
                    diff = items[midPoint] - integer;
                    upperBound = midPoint - 1;
                }
                else if ((items[midPoint] - integer) < 0)
                {
                    lowerBound = midPoint + 1;
                }
                else
                {
                    upperBound = midPoint - 1;
                }
            }
            if (index == -1) return items.Length;
            return index;
        }
    }
}
