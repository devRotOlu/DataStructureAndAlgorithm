namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class LongestPrefix
    {
        /// time complexity O(n^2) space-complexity O(n)
        static public string GetLongestCommonPrefix(string[] words)
        {
            var shortestString = words.MinBy(x => x.Length);
            for (int i = shortestString!.Length; i > 0; i--)
            {
                var prefix = shortestString[..i];
                if (words.All(word => word.StartsWith(prefix)))
                {
                    return shortestString[..i];
                }
            }

            return "";
        }
    }
}
