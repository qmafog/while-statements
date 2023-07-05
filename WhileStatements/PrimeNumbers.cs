namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            uint i = n / 2, count = 0;
            if (n < 2)
            {
                count = 1;
            }

            while (i > 1)
            {
                if (n % i == 0)
                {
                    count++;
                    break;
                }

                i--;
            }

            if (count == 0)
            {
                return true;
            }

            return false;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            while (n > 3)
            {
                if (IsPrimeNumber(n))
                {
                    return n;
                }

                n--;
            }

            if (n == 1)
            {
                n--;
            }

            return n;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            if (n <= 1 || count <= 0)
            {
                return 0;
            }

            uint sum = 0;
            uint primesFound = 0;

            for (uint num = n; num > 1 && primesFound < count; num--)
            {
                if (IsPrimeNumber(num))
                {
                    sum += num;
                    primesFound++;
                }
            }

            return sum;
        }
    }
}
