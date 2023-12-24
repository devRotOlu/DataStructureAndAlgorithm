namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class JumpGame
    {
        static public bool CanReachLastCell(int[] integers)
        {
            int h = integers.Length;
            int index = 0, maxReach = 0;
            while (index < h && index <= maxReach)
            {
                maxReach = Math.Max(index + integers[index],maxReach);
                index++;
            }
            if (index == h)
                return true;
            return false;
        }
    }
}
