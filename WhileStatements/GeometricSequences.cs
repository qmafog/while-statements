namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint i = 0, j;
            uint sum = 0;
            uint elem;
            while (i < n)
            {
                j = 0;
                elem = a;
                while (j < i)
                {
                    elem *= r;
                    j++;
                }

                sum += elem;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            const uint r = 3;
            const uint a = 13;
            uint i = 0, j;
            uint sum = 0;
            uint elem;
            while (i < n)
            {
                j = 0;
                elem = a;
                while (j < i)
                {
                    elem *= r;
                    j++;
                }

                sum += elem;
                i++;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint i = 0, j;
            uint sum = 0;
            uint elem;
            do
            {
                j = 0;
                elem = a;
                while (j < i)
                {
                    elem *= r;
                    j++;
                }

                sum += elem;
                i++;
            }
            while (elem <= maxTerm);

            return i - 1;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint i = 0, j;
            uint sum = 0, count = 0;
            uint elem;
            while (i < n)
            {
                j = 0;
                elem = a;
                while (j < i)
                {
                    elem *= r;
                    j++;
                }

                if (elem >= minTerm)
                {
                    sum += elem;
                    count++;
                }

                i++;
            }

            return count;
        }
    }
}
