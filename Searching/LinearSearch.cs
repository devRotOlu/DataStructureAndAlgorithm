namespace DataStructureAndAlgorithm.Searching
{
    public class LinearSearch<T>where T:IComparable<T>
    {
        static public bool Contains(T item, T[] itemsArray)
        {
            for (int i = 0; i < itemsArray.Length - 1; i++)
            {
                if (itemsArray[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
