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

            try
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                //number of array of rotate
                int n = Convert.ToInt32(tokens_n[0]);
                //shift k time
                int k = Convert.ToInt32(tokens_n[1]);
                //count of returned indice
                int q = Convert.ToInt32(tokens_n[2]);

                string[] a_temp = Console.ReadLine().Split(' ');
                //Array to rotate
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                if (a.Length != n)
                {
                    return;
                }

                var arr = a.ToList();
                var temp = 0;
                for (int i = 0; i < k; i++)
                {
                    temp = arr.Last();
                    arr.RemoveAt(arr.Count - 1);
                    arr.Insert(0, temp);

                }
                
                //indice to return from array
                for (int a0 = 0; a0 < q; a0++)
                {
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a[m]);
                }

            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        } 
    }
}
