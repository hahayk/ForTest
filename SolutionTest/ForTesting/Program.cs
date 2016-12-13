using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(killKthBit(37, 3));
        }

        static int killKthBit(int n, int k)
        {
            return n & ~(1 << k-1);
        }

    }
}