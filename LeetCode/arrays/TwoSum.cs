namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class TwoSum
    {
        static public int[] GetTwoSum(int[] numbers, int target)
        {
            // Space complexity = K
            // Time complexiy  O(n^2)
            int[] sumIndex = new int[2];
            var i = 0;
            while (sumIndex[0] + sumIndex[1] == 0 && i < numbers.Length - 1)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {

                    if (numbers[j] + numbers[i] == target)
                    {
                        sumIndex[0] = i;
                        sumIndex[1] = j;
                        break;
                    }
                }
                i++;
            }
            return sumIndex;
        }

        static public void ReqGetTwoSum(int[] numbers, int target, out int index1, out int index2)
        {
            /// Time complexity O(n)
            /// Space Complexity O(n)
            var indexArray = GetTwoSumIndexes(numbers, 0, target);
            index1 = indexArray[0];
            index2 = indexArray[1];
        }

        static private int[] GetTwoSumIndexes(int[] numbers, int fixedIndex, int target)
        {
            var sumIndex = new int[2];
            for (int i = fixedIndex + 1; i < numbers.Length; i++)
            {
                if (numbers[fixedIndex] + numbers[i] == target)
                {
                    sumIndex[0] = i;
                    sumIndex[1] = fixedIndex;
                    break;
                }
            }

            if (fixedIndex++ < numbers.Length - 1 && sumIndex[0] + sumIndex[1] == 0)
            {
                return GetTwoSumIndexes(numbers, fixedIndex, target);
            }
            return sumIndex;
        }
    }
}
