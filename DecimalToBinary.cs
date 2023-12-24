using System.Text;

namespace DataStructureAndAlgorithm
{
    public class DecimalToBinary
    {
        static public string Convert(uint decimalNumber)
        {
            string binaryNumber = "";
            uint numerator = decimalNumber;
            string result = "00000000 00000000 00000000 00000000";
                while (numerator != 0)
                {
                    if (binaryNumber.Length % 9 == 8)
                    {
                        binaryNumber = numerator % 2 + " " + binaryNumber;
                    }
                    else
                    {
                        binaryNumber = numerator % 2 + binaryNumber;
                    }
                    numerator = numerator / 2;
                }
            
            result = result.Remove(result.Length - binaryNumber.Length);
            return result + binaryNumber;
        }

        static public StringBuilder Convert2(int val)
        {
            int dispMask = 1 << 31;
            StringBuilder bitBuffer = new StringBuilder(35);
            for (int i = 1; i <= 32; i++)
            {
                if ((val & dispMask) == 0) bitBuffer.Append("0");
                else bitBuffer.Append("1");
                val <<= 1;
                if ((i % 8) == 0) bitBuffer.Append(" ");
            }
            return bitBuffer;
        }
    }
}
