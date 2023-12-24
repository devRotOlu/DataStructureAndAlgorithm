namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class ValidParentheses
    {
        // space-complexity O(1) time complexity - O(n^2)
        static public bool? IsValidParentheses(string parentheses)
        {
            if (string.IsNullOrEmpty(parentheses))
            {
                return null;
            }
            var openingTags = "([{";
            var closingTags = ")]}";

            for (int i = 0; i <= (parentheses.Length - 1); i++)
            {
                if (i % 2 == 0 && !openingTags.Contains(parentheses[i]))
                {
                    return false;
                }
                else if (i % 2 > 0 && (!closingTags.Contains(parentheses[i]) || !(closingTags.IndexOf(parentheses[i]) == openingTags.IndexOf(parentheses[i - 1]))))
                {
                    return false;
                }
            }
            return true;
        }

        // time-complexity O(n)  space-complexity O(1)
        static public bool? IsValidParentheses2(string parentheses)
        {
            if (string.IsNullOrEmpty(parentheses))
            {
                return null;
            }

            return CheckValidity(parentheses, 0);
        }

        // Divide and Conquer Recursion 
        static private bool CheckValidity(string parentheses, int index, bool isValid = true)
        {
            if (index >= parentheses.Length - 1 || !isValid)
            {
                return isValid;
            }
            var openingTags = "([{";
            var closingTags = ")]}";

            if (openingTags.Contains(parentheses[index]) && closingTags.Contains(parentheses[index + 1]) && (openingTags.IndexOf(parentheses[index]) == closingTags.IndexOf(parentheses[index + 1])))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return CheckValidity(parentheses, index + 2, isValid);
        }
    }
}
