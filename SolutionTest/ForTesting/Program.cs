using System;

namespace ForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(secondRightmostZeroBit(37));
        }

        static int secondRightmostZeroBit(int n)
        {
            return (-~((n-~(n^(n+1))/2 ^ (n-~(n^(n+1))/2+1)))/2);
        }


    }
}
