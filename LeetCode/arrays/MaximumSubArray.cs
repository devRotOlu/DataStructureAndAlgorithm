﻿namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class MaximumSubArray
    {
        static public int MaxSum(int[] integers)
        {
            int size = integers.Length;
            int max_so_far = int.MinValue;
            int max_ending_here = 0;
            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + integers[i];
                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;
                if (max_ending_here < 0)
                    max_ending_here = 0;
            }
            return max_so_far;
        }
    }
}
