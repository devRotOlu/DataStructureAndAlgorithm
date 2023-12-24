using System.Collections;

namespace DataStructureAndAlgorithm
{
    public class EratosthenesSieve
    {
        static public string BuildSieve(BitArray bits)
        {
            string primes = string.Empty;
            for (int i = 0; i <= bits.Count - 1; i++) bits.Set(i, true);
            int lastBit = (int)Math.Sqrt(bits.Count);
            for (int i = 2; i <= lastBit - 1; i++)
            {
                if (bits.Get(i))
                    for (int j = 2 * i; j <= bits.Count - 1; j++)
                        bits.Set(j, false);
            }
            int counter = 0;
            for (int i = 1; i <= bits.Count - 1; i++)
            {
                if (bits.Get(i))
                {
                    primes += i.ToString();
                    counter++;
                    if ((counter % 7) == 0) primes += "\n";
                    else primes += "\n";
                }
            }
            return primes;
        }
    }
}
