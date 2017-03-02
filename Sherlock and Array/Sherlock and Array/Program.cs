using System;
using System.Collections.Generic;
using System.Linq;

namespace Sherlock_and_Array
{
    class Solution
    {
        static void Main(string[] args)
        {
            //test case count
            int testCaseCnt = Convert.ToInt32(Console.ReadLine());
            List<int> array = new List<int>();

            for (int i = 0; i < testCaseCnt; i++)
            {
                //remove all elements from array
                array.Clear();

                //get array items from Console
                int InputArraySize = Convert.ToInt32(Console.ReadLine());

                //for (int j = 0; j < InputArraySize; j++)
                {
                    var str = Console.ReadLine();

                    if(InputArraySize == 1)
                    {
                        Console.WriteLine("YES");
                        continue;
                    }
                    if (InputArraySize == 2 )
                    {
                        Console.WriteLine("NO");
                        continue;
                    }

                    string curStr = string.Empty;
                    int curInd = 0;

                    for (int k = 0; k < str.Length; ++k, ++curInd)
                    {
                        if (str[k] != ' ')
                        {
                            curStr += str[k];

                            if ((curInd + 1) </*= InputArraySize */str.Length && str[k + 1] != ' ')
                            {
                                continue;
                            }
                            else
                            {
                                array.Add(Convert.ToInt32(curStr.ToString()));
                                curStr = string.Empty;
                            }
                        }
                    }
                }

                Sum(array);
            }
        }

        private static void Sum(List<int> arrSum)
        {
            //List<int> arr = new List<int>() { 1, 2, 3, 3 };
            bool isContain = false;

            for (int i = 1; i < arrSum.Count - 1; i++)
            {
                if (arrSum.GetRange(0, i).Sum() ==
                    arrSum.GetRange(i + 1, arrSum.Count - i - 1).Sum())
                {
                    isContain = true;
                    break;
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
