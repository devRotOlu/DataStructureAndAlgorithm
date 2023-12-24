namespace DataStructureAndAlgorithm.Sorting
{
    public class ShellSort
    {
        static public void Sort(int[] array)
        {
            var length = array.Length;
            for (int gap = length/2; gap > 0; gap /=2)
            {
                for (int i = gap; i < length; i++)
                {
                    var temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                        array[j] = array[j - gap];
                    array[j] = temp;
                }
            }
        }
    }
}
