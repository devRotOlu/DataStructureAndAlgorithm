namespace DataStructureAndAlgorithm.Sorting
{
    public class BubbleSort<T> where T: IComparable
    {
        // Algorithm for bubble sort.
        //1. Iterate through the collection and compare adjacent elements. 
        //2. Swap adjacent elements in incorrect order
        //3. continue iterating, stop iteration when a loop doesn't contain any adjacent elements wrongly arranged.

        private T[] Numbers { get; set; }

        public BubbleSort(T[] _numbers)
        {
            Numbers = _numbers;
        }

        public void SortInAscending()
        {
            var arrayLength = Numbers.Length;

            var stopLoop = false;

            while (!stopLoop)
            {
                stopLoop = true;

                for (int i = 1; i < arrayLength; i++)
                {
                    var firstElement = Numbers[i - 1];
                    var secondElement = Numbers[i];

                    var sizeIndex = firstElement.CompareTo(secondElement);

                    if (sizeIndex > 0)
                    {
                        stopLoop = false;
                        Numbers[i] = firstElement;
                        Numbers[i - 1] = secondElement;
                    }

                }
            }

            foreach (var number in Numbers)
            {
                Console.WriteLine(number);
            }

        }

    }
}
