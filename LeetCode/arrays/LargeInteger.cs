namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class LargeInteger
    {
        static public int[] PlusOne(int[] digits)
        {
            var digitCount = digits.Length - 1;
            var integer = 0;
            for (int i = 0; i <= digitCount; i++)
            {
                if(i != digitCount)
                    integer += digits[i] * (int)Math.Pow(10, digitCount - i);
                else
                    integer += digits[i] + 1;
            }

            var _integer = integer.ToString();
            var _digits = new int[_integer.Length];

            for (int i = 0; i < _digits.Length; i++)
                _digits[i] = int.Parse(_integer[i].ToString());
            return _digits;
        }

        static public int[] PlusOne2(int[] digits)
        {
            var leftOver = 1;
            var length = digits.Length - 1;
            for (int i = length; i >= 0; i--)
            {
                var temp = digits[i] + leftOver;
                if (i != length)
                    digits[i] = temp % 10;
                else digits[i] = temp;
                leftOver = temp / 10;
            }
            return digits;
        }
    }
}
