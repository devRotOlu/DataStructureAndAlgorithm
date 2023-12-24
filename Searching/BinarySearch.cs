namespace DataStructureAndAlgorithm.Searching
{
    public class BinarySearch<T> where T : IComparable<T>
    {
        static public int GetItemIndex(T searchItem, T[] items)
        {
            var lowerBound = 0;
            var upperBound = items.Length - 1;

            while (lowerBound <= upperBound)
            {
                var midPoint = (upperBound + lowerBound) / 2;
                if (items[midPoint].CompareTo(searchItem) == 0) return midPoint;
                else if(items[midPoint].CompareTo(searchItem) < 0)
                    lowerBound = midPoint + 1;
                else  upperBound = midPoint - 1;
            }
            return -1;
        }
    }
}
