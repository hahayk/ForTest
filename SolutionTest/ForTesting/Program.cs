using System;

namespace ForTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(rangeBitCount(2, 7));
        }

        static int rangeBitCount(int a, int b)
        {
            var cnt = 0;

            for (int j = a; j <= b; ++j)
            {
                for (int i = 0; i < 8; ++i)
                {
                    if ((j & (1 << i)) != 0)
                    {
                        ++cnt;
                    }
                }
            }
            return cnt;
        }
    }
}
