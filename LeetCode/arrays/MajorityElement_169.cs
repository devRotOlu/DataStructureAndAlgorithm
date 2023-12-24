namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    internal class MajorityElement_169
    {
        static public int MajorityElement(int[] numbers)
        {
            Array.Sort(numbers);
            int prevIntegerCount = 0;
            var newIntegerCount = 1;
            int newIndexStart = 0;
            int majorElement = numbers[0];
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    newIntegerCount++;
                }         
                else if(numbers[i - 1] != numbers[i])
                {
                    if ((i - newIndexStart) > prevIntegerCount)
                    {
                        majorElement = numbers[i - 1];
                        prevIntegerCount = newIntegerCount;
                    }
                            
                    newIndexStart = i;
                    newIntegerCount = 1;
                }

                if (majorElement != numbers[i] && newIntegerCount > prevIntegerCount)
                    majorElement = numbers[i];
            }

            return majorElement;
        }
    }
}
