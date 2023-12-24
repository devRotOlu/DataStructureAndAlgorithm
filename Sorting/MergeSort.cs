namespace DataStructureAndAlgorithm.Sorting
{
    public class MergeSort
    {
        static public void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                var mid = left + (right - left) / 2;
                Sort(array, left,mid);
                Sort(array, mid + 1,right);
                Merge(array,left,mid,right);
            }
        }

        static private void Merge(int[] array, int left,int mid,int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            /// Sub-arrays
            int[] L = new int[n1];
            int [] R = new int[n2];

            int i , j ;
            for (i = 0; i < n1; i++) L[i] = array[left + i];
            for (j = 0; j < n2; j++) R[j] = array[mid + 1 + j];

            /// initial indexes of sub-arrays
            i = 0; j = 0;

            // intial index of merged sub-array
            int k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }

        }
    }
}
