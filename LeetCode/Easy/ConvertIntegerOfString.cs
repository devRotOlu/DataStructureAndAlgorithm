using System.Text;

namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class ConvertIntegerOfString
    {
        static public int Convert(string word)
        {
            if (word.Length == 0)
            {
                throw new ArgumentException("An Empty string isn't accepted.");
            }

            word = word.TrimStart();
            string sign = "";

            if (word[0] == '-' || word[0] == '+') 
                sign = word[0].ToString();

            var index = (sign.Length != 0) ? 1 : 0;    
            var integer = new StringBuilder(word.Length);

            while (index < word.Length)
            {
                if (int.TryParse(word[index].ToString(), out int _integer))
                    integer.Append(_integer);
                else break;
                index++;
            }

            try
            {
                if (sign == "-") int.Parse($"-{integer}");
                else int.Parse(integer.ToString());
            }
            catch (OverflowException)
            {
                if (sign == "-") return int.MinValue;
                else return int.MaxValue;
            }
            
            return int.Parse((sign + integer))  ;
        }
    }
}
