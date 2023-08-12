namespace DataStructureAndAlgorithm.Sorting
{
    public class InsertionSort<T> where T : IComparable<T>
    {
        //. Insertion sort algorithm
        //1. The collection is divided into two parts; sorted and unsorted. At the beginning,the first element in  the collection is classed as sorted.
        //2. The first element in the unsorted part is removed and placed at an appropriate position within the sorted part until the collection is sorted.

        private T[] Numbers { get; set; }

        public InsertionSort(T[] _numbers)
        {
            Numbers = _numbers;
        }

        public void SortInAscending()
        {
            var arrayLength = Numbers.Length;

            for (int i = 1; i < arrayLength; i++)
            {
                var numToSort = Numbers[i];

                var j = i; var sizeIndex = 1;

                while ( j > 0 && sizeIndex > 0)
                {
                    sizeIndex = Numbers[j - 1].CompareTo(numToSort);
                    if (sizeIndex > 0)
                    {   var numInSort = Numbers[j - 1];
                        Numbers[j] = numInSort;
                        Numbers[j - 1] = numToSort;
                    }

                    j--;
                }
            }

            foreach (var number in Numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
