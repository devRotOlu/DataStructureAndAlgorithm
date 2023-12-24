namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class SingleNumber
    {
        static public int GetSingleNumber(int[] numbers)
        {
            var max = numbers.Max(); /// n-order
            var min = numbers.Min(); /// n-order
            var diff = 0;
            if (min < 0)
                diff = diff - min;
            var valueIndicator = Math.Pow(10,max + diff + 1);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    valueIndicator += Math.Pow(10,(max + diff) - (diff - Math.Abs(numbers[i])));
                else
                    valueIndicator += Math.Pow(10, (max + diff) - (numbers[i] + diff));
            }

            var _valueIndicator = valueIndicator.ToString();

            var value = double.MinValue;

            for (int i = 1; i <= _valueIndicator.Length; i++)
            {
                if (_valueIndicator[i].ToString() == "1")
                {
                    if (min < 0)
                        value = min + (i - 1);
                    else value = 0 + (i - 1);
                    break;
                }     
            }
               
            return (int)value;
        }

        static public int GetSingleNumber2(int[] numbers)
        {
            var single = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                single = single ^ numbers[i];
            return single;
        } 
    }
}
