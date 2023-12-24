namespace DataStructureAndAlgorithm.LeetCode.Medium
{
    public class HighestFrequency
    {
        static int GetHighestFrequency(int[] numbers, int incrementCount)
        {
            Array.Sort(numbers);
            var highestFreq = 0;

            for (int i = numbers.Length - 1; i >= 1; i--)
            {
                var diffSum = 0;
                var freqCount = 1;
                for (int j = 0; j < i; j++)
                {
                    diffSum = diffSum + (numbers[i] - numbers[j]);
                    if (diffSum <= incrementCount)
                    {
                        freqCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                highestFreq = Math.Max(highestFreq, freqCount);
            }
            return highestFreq;
        }
    }
}
