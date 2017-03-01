using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sherlock_and_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 1, 2, 3, 3 };
            bool isContain = false;

            for (int i = 1; i < arr.Count - 1; i++)
            {
                if (arr.GetRange(0, i).Sum() ==
                    arr.GetRange(i + 1, arr.Count - i - 1).Sum())
                {
                    isContain = true;
                    break;
                }
            }


            if (isContain)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        private static int Sum(List<int> arrSum)
        {
            return arrSum.Sum();
        }


    }
}
