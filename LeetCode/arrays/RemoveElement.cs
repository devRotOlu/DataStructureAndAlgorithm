namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class RemoveElement
    {
        static public int Remove(int[] numbers, int target)
        {
            Array.Sort(numbers);
            var integerCount = numbers.Count((x) => x == target);

            int left, right = numbers.Length - 1;
            left = - 1;
            while (left < numbers.Length)
            {
                left++;
                if (numbers[left] == target) break;
            }
            var nonIntegerCount = numbers.Length - integerCount;
            while (numbers[left] != numbers[right] && integerCount > 0)
            {
                var temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;
                left++; right--; integerCount--;
            }

            return nonIntegerCount;
        }

        static public int Remove2(int[] numbers,int target)
        {
            var right = numbers.Length;
            var index = 0;
            while (index != right)
            {
                if (numbers[index]== target)
                {
                    right--;
                    while (index != right && numbers[right] == target) right--;
                    var temp = numbers[index];
                    numbers[index] = numbers[right];
                    numbers[right]= temp;
                }
                index++;
            }
            return numbers.Length - (numbers.Length - right);
        }

        static public int Remove3(int[] numbers, int target)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != target) numbers[count++] = numbers[i];
            }
            return count;
        }
    }
}
