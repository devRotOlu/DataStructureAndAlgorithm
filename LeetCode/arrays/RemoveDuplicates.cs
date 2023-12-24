namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class RemoveDuplicates
    {
        static public void PriortizeUniqueElements1(int[] numbers, out int lastUniqueIndex, out int[] modifiedNumbers)
        {
            lastUniqueIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[lastUniqueIndex] && i != lastUniqueIndex + 1)
                {
                    numbers[++lastUniqueIndex] = numbers[i];
                }
            }
            lastUniqueIndex++;
            modifiedNumbers = numbers;
        }
        static public void PriortizeUniqueElements2(int[] numbers, out int lastUniqueIndex, out int[] modifiedNumbers)
        {
            lastUniqueIndex = 1;
            foreach (int i in numbers)
            {
                if (numbers[lastUniqueIndex - 1] != i)
                {
                    numbers[lastUniqueIndex++] = i;
                }
            }
            modifiedNumbers = numbers;
        }

    }
}
