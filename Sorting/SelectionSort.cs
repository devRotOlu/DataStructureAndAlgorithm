namespace DataStructureAndAlgorithm.Sorting
{
    public class SelectionSort
    {
        // Alogorithm for selection sort
        //. The collection is divided into two parts; sorted and unsorted.
        //.  The smallest element for the sorted part is used to replace the first element of the unsorted part.
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
                var reducedNumbers = Numbers.Skip(i).ToArray();
                var minValue = reducedNumbers.Min();
                var minValueIndex = reducedNumbers.ToList()
                                                  .FindIndex(number=> number == minValue);
                var firstValue = reducedNumbers[0];
                reducedNumbers[minValueIndex] = firstValue;
                reducedNumbers[0] = minValue;
                reducedNumbers.CopyTo(Numbers, i);
            }

            foreach (var number in Numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
