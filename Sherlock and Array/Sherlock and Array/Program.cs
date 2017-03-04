using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Sherlock_and_Array
{
    class Solution
    {
        static void Main(string[] args)
        {
            //test case count
            List<int> array = new List<int>();
            int testCaseCnt = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCaseCnt; i++)
            {
                //remove all elements from array
                array.Clear();

                //get array items from Console
                int InputArraySize = Convert.ToInt32(Console.ReadLine());

                string[] strInputArr = Console.ReadLine().Split(' ');

                if (InputArraySize == 1)
                {
                    Console.WriteLine("YES");
                    continue;
                }
                if (InputArraySize == 2)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                array = new List<int>(Array.ConvertAll(strInputArr, int.Parse));

                //Stopwatch sw = new Stopwatch();

                //sw.Start();
                //Sum1(array);
                //sw.Stop();
                //Console.WriteLine($"Time for Sum {sw.ElapsedMilliseconds} Milliseconds");

                //Stopwatch sw1 = new Stopwatch();
                //sw1.Start();
                Sum(array);
                //sw1.Stop();
                //Console.WriteLine($"Time for Sum1 {sw1.ElapsedMilliseconds} Milliseconds");

            }
        }

        //private static void Sum1(List<int> arrSum)
        //{
        //    bool isContain = false;
            
             

        //    for (int i = 1; i < arrSum.Count - 1; i++)
        //    {
        //        if (arrSum.GetRange(0, i).Sum() ==
        //            arrSum.GetRange(i + 1, arrSum.Count - i - 1).Sum())
        //        {
        //            isContain = true;
        //            break;
        //        }
        //    }

        //    if (isContain)
        //    {
        //        Console.WriteLine("YES");
        //    }
        //    else
        //    {
        //        Console.WriteLine("NO");
        //    }
        //}

        private static void Sum(List<int> arrSum)
        {
            bool isContain = false;
            int a = arrSum[0];
            int b = 0;
            for (int i = 2; i < arrSum.Count; i++)
                b += arrSum[i];

            for (int i = 1; i < arrSum.Count - 1; i++)
            {
                if (a == b)
                {
                    isContain = true;
                    break;
                }
                else
                {
                    a += arrSum[i];
                    b -= arrSum[i + 1];
                }
            }
            if (isContain)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
