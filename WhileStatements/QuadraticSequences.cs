namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            long sum = 0;
            int i = 1;
            while (((a * i * i) + (b * i) + c) <= maxTerm)
            {
                sum += (a * i * i) + (b * i) + c;
                i++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            long i = startN;
            long sum = 0;
            while (i < startN + count)
            {
                sum += (a * i * i) + (b * i) + c;
                i++;
            }

            return sum;
        }
    }
}
