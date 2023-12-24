using System.Collections;

namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class Gap
    {
        static public int MaximumGap(int[] numbers)
        {
            var maxGap = 0;
            if (numbers.Length == 1)
                return maxGap;
            var max = numbers.Max();
            var min = numbers.Min();
            var hashTable = new Hashtable();
           
            for (int i = 0; i < numbers.Length; i++)
                hashTable.Add(numbers[i], numbers[i]);

            var lastValue = min;

            for (int i = min; i <= max; i++)
            {
                var value = hashTable[i];
                if ( value != null && ((int)value - lastValue) > maxGap)
                {
                    maxGap = (int)value - lastValue;
                    lastValue = (int)value;
                }else if(value != null)
                {
                    lastValue = (int)value;
                }
            }
            return maxGap;
        }
    }
}
