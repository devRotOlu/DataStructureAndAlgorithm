namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class ThreeSum
    {
        static public List<int[]> DistinctIndexSum(int[] numbers)
        {
            var indexArray = new List<int[]>();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                var firstIndex = i;
                var secondIndex = i + 1;
                var thirdIndex = secondIndex + 1;
                while (secondIndex < (numbers.Length - 1))
                {
                    var sum = numbers[firstIndex] + numbers[secondIndex] + numbers[thirdIndex];
                    var array = new int[3]{numbers[firstIndex],numbers[secondIndex],
                            numbers[thirdIndex]};
                    if (sum == 0 && !indexArray.Any(x=>x.All(x=> array.Contains(x))))
                    {
                        indexArray.Add(array);
                    }
                    thirdIndex++;
                    if (thirdIndex == numbers.Length)
                    {
                        thirdIndex = ++secondIndex + 1;
                    }
                }
            }

            return indexArray;
        }

        static public IList<IList<int>> DistinctIndexSum2(int[] numbers)
        {
            if (numbers.Length < 3)
                return new List<IList<int>>();  

            Array.Sort(numbers);
            var result = new List<IList<int>>();
            int left, right;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) break;
                if (i > 0 && numbers[i] == numbers[i - 1]) continue;
                left = i + 1;
                right = numbers.Length - 1;
                while (left < right)
                {
                    int sum = numbers[i] + numbers[left] + numbers[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { numbers[i], numbers[left], numbers[right] });
                        while (left < right && numbers[left] == numbers[left + 1]) 
                            left++;
                        while (left < right && numbers[left] == numbers[right - 1])
                            right--;
                        left++;
                        right--;
                    }
                    else if (sum < 0)
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
