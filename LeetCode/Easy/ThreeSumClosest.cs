namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class ThreeSumClosest
    {
        static public int GetClosestSum(int[] integers,int target)
        {
            Array.Sort(integers);
            int left, right;
            var closestSum = int.MaxValue;
            for (int i = 0; i < integers.Length; i++)
            {
                if (i > 0 && integers[i] == integers[i - 1]) continue;
                left = i + 1;
                right = integers.Length - 1;
                while (left < right)
                {          
                    var sum = integers[i] + integers[left] + integers[right];
                    closestSum = Math.Abs(target - sum) < Math.Abs(target - closestSum)? sum : closestSum;
                    while (left < right && integers[right] == integers[right - 1])
                        right--;
                    right--;
                    if (right <= left)
                    {
                        right = integers.Length - 1;
                        while (left < right && integers[left] == integers[left + 1])
                            left++;
                        left++; 
                    }
                }
            }
            return closestSum;
        }

        static public int GetClosetSum2(int[] integers, int target)
        {
            Array.Sort(integers);
            int left, right;
            var closestSum = int.MaxValue;
            for (int i = 0; i < integers.Length; i++)
            {
                if (i > 0 && integers[i] == integers[i - 1]) continue;
                left = i + 1;
                right = integers.Length - 1;
                while (left < right)
                {
                    var sum = integers[i] + integers[left] + integers[right];
                    if (Math.Abs(target - closestSum) > Math.Abs(target - sum))
                        closestSum = sum;
                    if (sum > target) right--;
                    else left ++;
                }
            }
            return closestSum;
        }
    }
}
