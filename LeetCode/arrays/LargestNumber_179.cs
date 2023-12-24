using System.Text;

namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class LargestNumber_179
    {
        static public string LargestNumber(int[] numbers)
        {
            var _numbers = new string[numbers.Length];  
            for (int i = 0; i < numbers.Length; i++)
            {

            }
            var startIndex = numbers.Length - 1;
            var largestNumber = new StringBuilder("");
            for (int i = startIndex; i >= 0; i--)
            {
                largestNumber.Append(numbers[i].ToString());
            }
            return largestNumber.ToString();
        }
    }
}
