namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class SingleNumberII
    {
        static public int SingleNumber(int[] numbers)
        {
            int once = 0,twice = 0, thrice = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                twice = twice | (once & numbers[i]);
                once = once ^ numbers[i];
                thrice = once & twice;
                once = once & (~thrice);
                twice = twice & (~thrice);
            }
            return once;
        }
    }
}
