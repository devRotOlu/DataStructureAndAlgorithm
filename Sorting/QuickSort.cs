namespace DataStructureAndAlgorithm.Sorting
{
    public class QuickSort
    {
        // Algorithm
        //1. Pick some value such as the first or middle element of the array as a pivot.
        //2. Reorder the array such that the element lower than or equal to the pivot are placed before it and values greater than it are placed after it.
        //3. The set of values before the pivot forms the lower sub-array and the set after it forms the higher sub-array.
        //4. Each of the sub-arrays are ordered recursively by following steps 1 and 2.

        static public void Sort(int[] arr,int low,int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                Sort(arr,low,pi - 1);
                Sort(arr,pi + 1,high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
           var pivot = arr[high];
           var i = low - 1;
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
