namespace DataStructureAndAlgorithm.Searching
{
    public class JumpSearch<T> where T : IComparable<T>
    {

        public int Search(T[] values,T target)
        {
            if (values.Length == 0)
            {
                return -1;
            }
            
            var stepSize = (int)Math.Floor(Math.Sqrt(values.Length));

            int targetIndex = -1, lowerBound = -1, upperBound = 0, maxIndex = values.Length - 1;

            while (lowerBound < upperBound && targetIndex == -1 && lowerBound <= maxIndex)
            {
                if (upperBound <= maxIndex && values[upperBound].CompareTo(target) <= 0)
                {
                    if (values[upperBound].CompareTo(target) == 0)
                    {
                        targetIndex = upperBound;
                    }
                    else
                    {
                        lowerBound = upperBound;
                        upperBound += stepSize;
                    }
                }
                else
                {
                    if (values[lowerBound].CompareTo(target) == 0)
                    {
                        targetIndex = lowerBound;
                    }
                    else
                    {
                        lowerBound++;
                    }
                }
            }

            return targetIndex;
        }
    }
}
