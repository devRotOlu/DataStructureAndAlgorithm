namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class Duplicates
    {
        // time-complexity O(n) space-complexity O(1)
        static public bool ContainsDuplicates(int[] numbers)
        {
            int left = 0, right = 1;
            var containsDuplicates = false;
            var numbersLength = numbers.Length;
            while (left <= numbersLength - 2 && !containsDuplicates)
            {
                if (numbers[left] == numbers[right])
                {
                    containsDuplicates = true;
                }

                if (right == (numbersLength - 1))
                {
                    left++;
                    right = left + 1;
                }
                else
                {
                    right++;
                }
            }
            return containsDuplicates;
        }

        // time-complexity O(n) space-complexity O(n)
        static public bool ContainsDuplicates2(int[] numbers)
        {
            var uniqueNumbers =  new HashSet<int>(numbers);
            if (uniqueNumbers.Count != numbers.Length)
            {
                return true;
            }

            return false;   
        }
    }
}
