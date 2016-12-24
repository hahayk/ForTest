using System;
using System.Linq;
namespace ForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(isSmooth(72));
            Console.WriteLine(Math.Sqrt(100));


        }
        static bool isSmooth(int n)
        {
            for (int i = 2; i < Math.Sqrt(n); ++i)
            {
                for(int j = 2; j < Math.Sqrt(n); ++j)
                {
                    if(Math.Pow(i, j) == n)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}