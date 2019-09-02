using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFunc
{
    public class FuncClass
    {
        static void Main(string[] args)
        {
        }

        public static int Sum(int[] input)
        {
            int m1, m2;
            if (input.Length == 0)
            {
                Console.WriteLine("Array is empty");
                return -1;
            }
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
            return m1+m2;
        }
    }
}
