namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class RemoveDuplicatesII
    {
        static public int Remove(int[] integers)
        {
            int count = 1, elementIndex = 0;
            var length = integers.Length;
            for (int i = 0; i < length; i++)
            {
                if (count < 3 && elementIndex != 0)
                {
                    integers[elementIndex + 1] = integers[i];
                    elementIndex++;
                }

                if ((i + 1) < length && integers[i] == integers[i + 1])
                    count++;
                else count = 1;
             
                if (count == 3 && elementIndex == 0)
                    elementIndex = i;
            }
            return elementIndex + 1;     
        }
    }
}
