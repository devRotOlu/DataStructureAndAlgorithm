namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    internal class _Anagram : IComparable<_Anagram>
    {
        public string x;
        public int y;
        public _Anagram(string x, int y)
        {
            this.y = y;
            this.x = x;
        }
        public int CompareTo(_Anagram other)
        {
            return this.x.CompareTo(other.x);
        }

        static List<_Anagram> CreateDuplicate(string[] wordArr,int size)
        {
            List<_Anagram> dupArray = new List<_Anagram>();
            for (int i = 0; i < size ; i++)
            {
                var pair = new _Anagram(wordArr[i], i);
                dupArray.Add(pair);
            }
            return dupArray;
        }

        static void PrintAnagramsTogether(string[] wordArr,int size)
        {
            // dupArray to store the word-index pair
            var dupArray = CreateDuplicate(wordArr,size);
            // making copy of all the words
            // and their respective index
            // iterate through all dupArray and sort
            // characters in each word.
            for (int i = 0; i < size; i++)
            {
                _Anagram copy = dupArray[i];
                var arr = copy.x.ToCharArray();
                Array.Sort(arr);
                var x = new string(arr);
                _Anagram _copy = new (x,copy.y);
                dupArray[i] = _copy;
            }
            // now sort the whole vector to get the identical
            // words together
            dupArray.Sort();

            // now all the identical words are together but we
            // have lost the original form of string so through
            // index stored in the word-index pair fetch the
            // original word from main input.
            for (int i = 0; i < size; i++)
                Console.WriteLine(wordArr[dupArray[i].y] + " ");
        }
    }
}
