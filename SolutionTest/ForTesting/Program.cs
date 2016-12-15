using System;

namespace ForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(mirrorBits(97));
        }

        static int mirrorBits(int a)
        {
            var retval = 0;
            while(a > 0)
            {
                retval = (retval << 1) + (a & 1);
                a >>= 1;
            }

            return retval;
        }

    }
}


//1100001
//1000011

//a = a<<1 & 1