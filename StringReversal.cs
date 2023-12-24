namespace DataStructureAndAlgorithm
{
    public class StringReversal
    {
        // O(n)
        static public string? ReverseString(string word)
        {
            if (word == null)
            {
                return null;
            }
            var wordArray = word.ToCharArray(); /// O(n)

            var index = 0;

            var swapIndex = wordArray.Length - 1;

            // O(log^n2)
            while (index < Math.Ceiling((decimal)((wordArray.Length - 1) / 2)))
            {
                var temp = wordArray[index];
                wordArray[index] = wordArray[swapIndex];
                wordArray[swapIndex] = temp;
                index++;
                swapIndex--;
            }

            return string.Concat(wordArray); // O(n)
        }
    }
}
