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
            List<int> arr = new List<int>() { 1, 2, 3, 4 };

            for (int i = 1; i < arr.Count-1; i++)
            {
                if (Sum(arr.GetRange(0, i-1)) == 
                    Sum(arr.GetRange(i+1, arr.Count-1)))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            
        }

        private static int Sum(List<int> arrSum)
        {
            return arrSum.Sum();
        }

        
    }
}
