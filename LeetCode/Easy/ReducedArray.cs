namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class ReducedArray
    {
        static public int GetOperationCount1(int[] numbers)
        {
            return ReduceArray(numbers, 0);
        }

        static private int ReduceArray(int[] numbers, int operationCount)
        {
            if (numbers.All(num => num == numbers[0]))
            {
                return operationCount;
            }
            var maxNumberIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[maxNumberIndex])
                {
                    maxNumberIndex = i;
                }
            }
            var nextMaxNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > nextMaxNumber && numbers[i] < numbers[maxNumberIndex])
                {
                   nextMaxNumber = numbers[i];
                }
            }
            numbers[maxNumberIndex] = nextMaxNumber;
            operationCount++;
            return ReduceArray(numbers, operationCount);
        }

        static public int GetOperationCount2(int[] numbers)
        {
            //var maxValue = numbers.Max();
            //var maxValueCount = numbers.SkipWhile(x => x != maxValue).Count();
            //var operationCount = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < maxValue)
            //    {
            //        maxValue = numbers[i];
            //        operationCount += maxValueCount;
            //    }
            //}
            Array.Sort(numbers,(x,y)=>y.CompareTo(x));
            int step = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i-1])
                {
                    step += i;
                }
            }
            return step;
        }
    }
}
