namespace DataStructureAndAlgorithm.Sorting
{
    public class SelectionSort
    {
        // Alogorithm for selection sort
        //. The collection is divided into two parts; sorted and unsorted.
        //.  The smallest element for the unsorted part is used to replace the first element of the unsorted part and the length of the sorted path increases.
        // The above is continuosly done until the collection is sorted.

        private int[] Numbers { get; set; }

        public SelectionSort(int[] _numbers)
        {
            Numbers = _numbers;
        }

        public void SortInAscendingOrder()
        {
            var numbersLength = Numbers.Length;

            for (int i = 0; i < numbersLength; i++)
            {
                var smallestDigitIndex = i;

                for (int j = (i + 1); j < numbersLength; j++)
                {
                    if (Numbers[j] < Numbers[smallestDigitIndex])
                    {
                        smallestDigitIndex = j;
                    }
                }

                if (i != smallestDigitIndex)
                {
                    var temp = Numbers[smallestDigitIndex];
                    Numbers[smallestDigitIndex] = Numbers[i];
                    Numbers[i] = temp;
                }
            }

            foreach (var number in Numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
