namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class LongestSubstring
    { 
        /// Time complexity - O(n) space complexity- O(min(n,m)) 
        static public int UniqueLetteredSubstring1(string word)
        {
            var charSet = new HashSet<char>();
            int left = 0, right = 0, maxLength = 0;
            while (right < word.Length)
            {
                if (!charSet.Contains(word[right]))
                {
                    charSet.Add(word[right]);
                    right++;
                    maxLength = Math.Max(maxLength, charSet.Count);   
                }
                else
                {
                    charSet.Remove(word[left]);
                    left++;
                }
            }
            return maxLength;
        }

        /// Time Complexity- O(nlogn) space Complexity - O(1)
        static public int UniqueLetteredSubstring2(string word)
        {
            if (word.Length == 1)
            {
                return 1;
            }
            int left = 0, right = 1, maxLength = 0;
            while (right < word.Length)
            {
                for (int i = left; i < right; i++)
                {
                    if (word[i] == word[right])
                    {
                        left = i + 1;
                    }
                }
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }

            return maxLength;
        }
    }
}
