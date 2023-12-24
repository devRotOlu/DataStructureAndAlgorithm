namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class FourSum
    {
        static public List<int[]> DistinctIndexSum(int[] numbers,int target)
        {
            Array.Sort(numbers);

            if (numbers.Length < 4)
                return new List<int[]>();
            int left,right;
            var result = new List<int[]>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (target <= 0 && numbers[i] > 0) break;
                if (target > 0 && numbers[i] > target) break;
                if (i > 0 && numbers[i] == numbers[i - 1]) continue;
                left = i + 1;
                right = numbers.Length - 1;
                while (left < right)
                {
                    var sum = numbers[i] + numbers[right] + numbers[left] + numbers[right - 1];
                    if (sum == target)
                    {
                        result.Add(new int[] { numbers[i], numbers[right], numbers[left], numbers[right - 1] });
                        do right--; 
                        while (left < right && numbers[right] == numbers[right + 1] && numbers[right] == numbers[right - 1]);
                        do left++;
                        while (left < right && numbers[left] == numbers[left - 1]);
                    }
                    else if (sum  < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result;
        }
    }
}
