namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class LongestPalindromic
    {
        // Time complexity - O(n^2)
        public static string GetLongestPalindromic(string word)
        {
            var reversedWord = string.Concat(word.Reverse()); /// O(n)
            string longestPalindromic = string.Empty;
            return FindLongestPalindromic(word,reversedWord,0, longestPalindromic);
        }

        static string FindLongestPalindromic(string word,string reversedWord,int searchIndex,string longestPalindromic)
        {
            var patchedWord = word[searchIndex].ToString();
            for (int i = searchIndex + 1; i < word.Length; i++) // O(n)
            {
                patchedWord += word[i];

                if (word[i] == word[searchIndex])
                {
                    var reversedSearchIndex = (word.Length - 1) - searchIndex;
                    var reversedI = (word.Length - 1) - i;
                    var areEqual = patchedWord.Equals(reversedWord.Substring(reversedI,(reversedSearchIndex - reversedI) + 1));/// O(n)
                    if (areEqual  && patchedWord.Length > longestPalindromic.Length )
                    {
                        longestPalindromic = patchedWord;
                    }
                }
            }

            if (searchIndex++ < (word.Length - 1))
            {
                return FindLongestPalindromic(word,reversedWord,searchIndex,longestPalindromic);
            }

            return longestPalindromic;
        }
    }
}
