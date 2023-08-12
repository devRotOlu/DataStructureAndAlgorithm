namespace DataStructureAndAlgorithm.Sorting
{
    public class QuickSort<T> where T:IComparable
    {
        // Algorithm
        //1. Pick some value such as the first or middle element of the array as a pivot.
        //2. Reorder the array such that the element lower than or equal to the pivot are placed before it and values greater than it are placed after it.
        //3. The set of values before the pivot forms the lower sub-array and the set after it forms the higher sub-array.
        //4. Each of the sub-arrays are ordered recursively by following steps 1 and 2.

        public T[] Numbers { get; set; }

        public QuickSort(T[] _numbers)
        {
            Numbers = _numbers;
        }

        public void SortInAscending()
        {
            // Pick the first in the array as the initial pivot.
            var pivotIndex = 0;
            ReArrangeArray(pivotIndex);
        }

        private void ReArrangeArray(int pivotIndex)
        {
            var wasSwaped = true;
            var loopStart = pivotIndex;
            while (wasSwaped)
            {
                var swapElement = Numbers[pivotIndex];
                var swapElementindex = pivotIndex;
                wasSwaped = false;
                for (int i = loopStart; i < Numbers.Length; i++)
                {
                    var sizeIndex = Numbers[i].CompareTo(swapElement);
                    var shouldSwap = sizeIndex <= 0 && i != pivotIndex;
                    if (pivotIndex - loopStart > 1 && Numbers[i].CompareTo(Numbers[pivotIndex]) > 0)
                    {
                        shouldSwap = true;
                    }
                    
                    if (shouldSwap)
                    {
                        swapElement = Numbers[i];
                        swapElementindex = i;
                        wasSwaped = true;
                    }
                }

                if (wasSwaped)
                {
                    var pivot = Numbers[pivotIndex];
                    Numbers[pivotIndex] = swapElement;
                    Numbers[swapElementindex] = pivot;
                    pivotIndex = swapElementindex;
                }
            }

            if (pivotIndex != (Numbers.Length - 1))
                ReArrangeArray(pivotIndex);

        }
    }
}
