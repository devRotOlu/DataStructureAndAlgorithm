namespace DataStructureAndAlgorithm
{
    public class MaxMinNumber
    {
        static public int GetMaxNumber(int[] numbers, int index,int length)
        {
            int max;
            if (length - 1 == 0) return numbers[index];
           
            if (index >= (length - 2))
            {
                if (numbers[index] > numbers[index + 1]) return numbers[index];
                else return numbers[index + 1];
            }

            max = GetMaxNumber(numbers, index + 1, length);

            if (numbers[index] > max) return numbers[index];
            else return max;
        }

        static public int GetMinNumber(int[] numbers, int index, int length)
        {
            int min;
            if (length - 1 == 0) return numbers[index];
            if (index >= length - 2)
            {
                if (numbers[index] < numbers[index + 1]) return numbers[index];
                else return numbers[index + 1];
            }
            min = GetMinNumber(numbers, index + 1, length);
            if (numbers[index] < min) return numbers[index];
            else return min;
        }
    }
}
