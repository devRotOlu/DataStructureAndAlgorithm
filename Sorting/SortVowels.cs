using System;

namespace DataStructureAndAlgorithm.Sorting
{
    public class SortVowels
    {
        // Given a 0-indexed string s,permute s to get a new string t such that:

        //All consonants remain in their original places. More formally, if there is an index i with 0 <= i < s.length such that s[i] is a consonant, then t[i] = s[i].

        // The vowels must be sorted in the nondecreasing order of their ASCII values. More formally, for pairs of indices i, j with 0 <= i < j < s.length such that s[i] and s[j] are vowels, then t[i] must not have a higher ASCII value than t[j]

        // Return the resulting string:

        //The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in lowercase or uppercase.Consonants comprise all letters that are not vowels.

        private string[] Vowels => new string[]
        {
            "a",
            "e",
            "i",
            "o",
            "u",
        };

        public string Alphabets { get; set; }

        public SortVowels(string alphabets)
        {
            Alphabets = alphabets;
        }

        public void SortVowelsInAscending()
        {
            Func<char,bool> _isVowel = _char => Vowels.Contains(_char.ToString().ToLower());

            var charArray = Alphabets.ToCharArray();
            var charVowels = charArray.Where(_isVowel).ToArray();

            if (charVowels.Length > 1)
            {
                var firstVowel = charVowels[0];
                var loopStart = Alphabets.IndexOf(firstVowel);
                var loopEnd = charArray.Length;
                // using insertion sort algorithm

                for (int i = (loopStart + 1); i < loopEnd; i++)
                {
                    var charToSort = charArray[i];

                    int j = i, sortIndex = i;
                    var isBigger = false;
                    var isVowel = Vowels.Contains(charToSort.ToString().ToLower());

                    if (isVowel)
                    {
                        while (j > loopStart)
                        {
                            j--;

                            isBigger = (int)charArray[j] > (int)charToSort;

                            isVowel = Vowels.Contains(charArray[j].ToString().ToLower());

                            if (isBigger && isVowel)
                            {
                                var charInSort = charArray[j];
                                charArray[sortIndex] = charInSort;
                                charArray[j] = charToSort;
                                sortIndex = j;
                            }
                        }
                    }
                }
            }

            Alphabets = String.Join("", charArray);
        }
    }
}
