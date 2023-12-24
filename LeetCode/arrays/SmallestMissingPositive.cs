namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class SmallestMissingPositive
    {
        static public int GetMissingPositive(int[] numbers)
        {
            int ptr = 0;
            var length = numbers.Length;
            // Check if 1 is present
            for (int i = 0; i < length; i++)
            {
                if (numbers[i] == 1)
                {
                    ptr = 1;
                    break;
                }
            }

            // if 1 is not present
            if (ptr == 0) return 1;

            // changing values to 1.
            for (int i = 0; i < length; i++)
                if(numbers[i] <= 0 || numbers[i] > length)
                    numbers[i] = 1;
            // updating indices according to values
            for(int i = 0; i < length; i++)
                numbers[(numbers[i] - 1)% length] += length;
            // Finding which index has value less than length
            for (int i = 0; i < length; i++)
                if (numbers[i] < length)
                    return i + 1;
            // If array has values from 1 to n
            return length + 1;
        }
    }
}
