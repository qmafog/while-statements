namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            ulong digit, sum = 0;
            while (n > 0)
            {
                digit = n % 10;
                sum += digit;
                n /= 10;
            }

            return sum;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            ulong digit, prod = 1;
            if (n == 0)
            {
                prod = 0;
            }

            while (n > 0)
            {
                digit = n % 10;
                prod *= digit;
                n /= 10;
            }

            return prod;
        }
    }
}
