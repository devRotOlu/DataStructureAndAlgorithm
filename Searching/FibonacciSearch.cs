namespace DataStructureAndAlgorithm.Searching
{
    public class FibonacciSearch<T> where T : IComparable<T>
    {
        public int Search(T[] values,T target)
        {
            var fib2 = 0;
            var fib1 = 1;
            var fib = fib1 + fib2;

            var offset = -1;

            var arrayLength = values.Length;

            while (fib < arrayLength)
            {
                fib2 = fib1;
                fib1 = fib;
                fib = fib1 + fib2;
            }

            while (fib > 1)
            {
                int i = Math.Min((offset + fib2), arrayLength - 1);

                if (values[i].CompareTo(target) < 0)
                {
                    fib = fib1;
                    fib1 = fib2;
                    fib2 = fib - fib1;
                    offset = i;
                }
                else if (values[i].CompareTo(target) > 0)
                {
                    fib = fib2;
                    fib1 = fib1 - fib2;
                    fib2 = fib - fib1;
                }
                else
                {
                    return i;
                }
            }

            if (fib1 == 1 && values[offset + 1].CompareTo(target) == 0)
            {
                return offset + 1;
            }

            return -1;
        }
    }
}
