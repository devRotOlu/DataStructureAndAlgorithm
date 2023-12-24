namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class Anagram
    {
        static public IList<IList<string>> GroupAnagrams(string[] words)
        {
            var anagrams = new List<IList<string>>();
            var dictionary = new Dictionary<int,int>();
            var index = 0;
            for (int i = 0; i < words.Length; i++)
            {
                var charCode = GetCharCode(words[i]);
                if (!dictionary.ContainsKey(charCode))
                {
                    dictionary.Add(charCode, index);
                    anagrams.Add(new List<string>());
                    anagrams[index].Add(words[i]);
                    index++;
                }
                else
                {
                    var _index = dictionary[charCode];
                    anagrams[_index].Add(words[i]);
                }
            }
            return anagrams;
        }

        static private int GetCharCode(string word)
        {
            var chars = word.ToCharArray();
            var charCode = 0;
            for (int i = 0; i <chars.Length; i++)
                charCode += (int)chars[i];
            return charCode;
        }
    }
}
