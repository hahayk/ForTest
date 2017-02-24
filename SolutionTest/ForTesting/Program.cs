using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Translate
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 5, 1, 2, 3, 4, 5 };
            int sum = numbers.Count();
            for (int i = 1; i <= numbers[0]; ++i)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);

            //ArrayList str = new ArrayList();
            //str.AddRange(new string[] { "1", "2", "3" });

            //Console.WriteLine("This collection has {0} items.", str.Count);
            //Console.WriteLine();


            //str.Add("4");

            //Console.WriteLine("This collection has {0} items.", str.Count);
            //Console.WriteLine();

            //str.RemoveAt(2);

            //Console.WriteLine("This collection has {0} items.", str.Count);
            //Console.WriteLine();

        }
    }
}
