namespace DataStructureAndAlgorithm.Sorting
{
    public class ArraySplitter
    {
        // An element x of an integer array arr of length m is dominant if freq(x) * 2 > m, where freq(x) is the number of occurrences of x in arr. Note that this definition implies that arr can have at most one dominant element.

        // An element x of an integer array arr of length m is dominant if freq(x) * 2 > m, where freq(x) is the number of occurrences of x in arr. Note that this definition implies that arr can have at most one dominant element.

        // You can split nums at an index i into two arrays nums[0, ..., i] and nums[i + 1, ..., n - 1], but the split is only valid if:
        // 0 <= i < n - 1
        //  nums[0, ..., i], and nums[i + 1, ..., n - 1] have the same dominant element.

        // Here, nums[i, ..., j] denotes the subarray of nums starting at index i and ending at index j, both ends being inclusive. Particularly, if j < i then nums[i, ..., j] denotes an empty subarray.

        // Return the minimum index of a valid split. If no valid split exists, return -1.

        public int MinimumIndex(IList<int> nums)
        {
            var distinctNumbers = nums.Distinct().ToList();
            var elementCount = 0;
            var dominantElement = 0;
            foreach (var number in distinctNumbers)
            {
                var _elementCount = nums.ToList().FindAll(num=> num == number).Count;

                if (_elementCount > elementCount)
                {
                    dominantElement = number;
                    elementCount = _elementCount;
                }
            }

            if (elementCount > 1)
            {
                return GetMinimumIndex(0, nums.ToList(), dominantElement, 1);
            }

            return -1;
        }

        private int GetMinimumIndex(int startIndex,List<int> nums,int dominantElement,int arrayCount)
        {
            var isDominant = false;
            var dominantElementCount = 0;
            var elementCount = 0;
            int i = startIndex;
            for (; i < nums.Count; i++)
            {
                var element = nums[i];
                elementCount++;

                dominantElementCount = (element == dominantElement) ? dominantElementCount + 1 : dominantElementCount;

                isDominant = dominantElementCount * 2 > elementCount;

                if (dominantElementCount > 0 && arrayCount == 1 && isDominant)
                {
                    break;
                }
            }

            if (isDominant && arrayCount == 1)
            {
                return GetMinimumIndex((i + 1), nums, dominantElement, 2);
            }
            else
            {
                return (isDominant && arrayCount == 2) ? (startIndex - 1) : -1;
            }

        }
    }
}
