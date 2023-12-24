namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class ElementExtremeIndexes
    {
        static public int[] Search(int[] numbers, int target)
        {
            var firstIndex = ModifiedBinarySearch(numbers,target,true);
            var secondIndex = ModifiedBinarySearch(numbers,target,false);
            return new[] { firstIndex, secondIndex };
        }

        static private int ModifiedBinarySearch(int[] items,int integer,bool isFirst)
        {
            var lowerBound = 0;
            var upperBound = items.Length - 1;

            var index = -1;

            while (lowerBound <= upperBound)
            {
                var midPoint = (upperBound + lowerBound) / 2;
                if (items[midPoint].CompareTo(integer) == 0)
                {
                    index = midPoint;
                    if (isFirst)
                    {
                        upperBound = midPoint - 1;
                    }
                    else
                    {
                        lowerBound = midPoint + 1;
                    }
                }
                else if (items[midPoint].CompareTo(integer) < 0)
                {
                    lowerBound = midPoint + 1;
                }
                else
                {
                    upperBound = midPoint - 1;
                }
            }
            return index;
        }
    }
}
