namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class JumpGameII
    {
        static public int MinimumJumps(int[] integers)
        {
            if (integers.Length == 1)
                return 0;
            int maxReach = integers[0];
            int steps = integers[0];
            int jumps = 0;
            for (int i = 1; i < integers.Length - 1; i++)
            {
                maxReach = Math.Max(maxReach, integers[i] + i);
                steps--;
                if (steps == 0)
                {
                    jumps++;
                    steps = maxReach - i;
                }
            }
            return jumps + 1;
        }
    }
}
