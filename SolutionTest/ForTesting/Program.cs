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
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");


            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }
        } 

        private static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (var item in set)
            {
                Console.Write($"{item}");
            }

            Console.WriteLine("}");
        }
    }
}
