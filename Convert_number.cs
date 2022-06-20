using System;
using System.Collections.Generic;

namespace Solution
{
    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            // ������������ long � string
            string str = n.ToString();

            long[] mas = new long[str.Length];

            // ������������ string � int
            for (int i = 0; i < str.Length; i++)
            {
                mas[i] = Convert.ToInt32(str[str.Length - i - 1]) - 48;
            }

            return mas;

        }
    }
}