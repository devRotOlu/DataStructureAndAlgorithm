namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class PalindromeNumber
    {
        // Time-Complexity O(n) Space-complexity O(1)
        static public bool IsPalindromeNumber(int number)
        {
            var numberString = number.ToString();
            
            if (numberString.Length == 0)
            {
                return false;
            }
            int index = 0, arrayLength = numberString.Length;
            var isPalindrome = true;
            while (index <= Math.Ceiling((decimal)((arrayLength - 1)/2)) || !isPalindrome)
            {
                if (!numberString[index].Equals(numberString[arrayLength - index - 1]))
                {
                    isPalindrome = false;
                    break;
                }
                index++;
            }
            return isPalindrome;
        }

        // Time-Complexity O(log10(n)) Space-complexity O(1)
        static public bool IsPalindromeNumber2(int n)
        {
            var stringNumber = n.ToString();
            if (!int.TryParse(stringNumber[0].ToString(),out int _) || string.IsNullOrEmpty(stringNumber))
            {
                return false;
            }
            int reverse = 0;
            int temp = n;
            while (temp!=0)
            {
                reverse = (reverse * 10) + (temp % 10);
                temp = temp / 10;
            }

            return reverse == n;    
        }

        // Time-Complexity O(n) Space-Complexity O(n)
        static public bool IsPalindrome3 (int number)
        {
            var numberString = number.ToString();
            var stack = new Stack<char>(numberString.Length);
            foreach (var character in numberString)
            {
                stack.Push(character);
            }
            for (int i = 0; i < numberString.Length; i++)
            {
                if (!stack.Pop().Equals(numberString[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
