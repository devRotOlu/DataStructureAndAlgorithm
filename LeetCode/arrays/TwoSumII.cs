namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class TwoSumII
    {
        static public int[] TwoSum(int[] numbers, int target)
        {
            var lowerIndex = 0;
            var upperIndex = numbers.Length - 1;

            while (numbers[upperIndex] + numbers[lowerIndex] != target)
            {
                if (numbers[lowerIndex] + numbers[upperIndex] == target)
                    break;
                else if (numbers[upperIndex] + numbers[lowerIndex] > target)
                    upperIndex--;
                else lowerIndex++;
            }

            return new int[] { lowerIndex + 1, upperIndex + 1 };
        }
    }
}
