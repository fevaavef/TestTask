using System;

namespace SumFunc
{
    public class SumMethod
    {
        public static int Sum(int[] input)
        {
            int m1, m2;
            if (input == null || input.Length == 0)
                throw new InvalidOperationException("Array is empty or null");
            if (input.Length == 1)
                return input[0];
            m1 = input[0];
            m2 = input[1];
            for (int i = 2; i < input.Length; i++)
            {
                if (m2 < m1)
                {
                    int a = m2;
                    m2 = m1;
                    m1 = a;
                }
                if (input[i] < m2)
                    m2 = input[i];
            }
            try
            {
                int trySum = checked(m1 + m2);
            }
            catch (OverflowException)
            {
                throw new InvalidOperationException("Result is too large or too small");
            }
            return m1 + m2;
        }
    }
}

