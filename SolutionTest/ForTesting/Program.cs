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
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                evenNumbers.Add(i * 2);
                oddNumbers.Add((i * 2) + 1);
            }

            Console.WriteLine($"evenNumbers containg {evenNumbers.Count} elements");
            DisplaySet(evenNumbers);

            Console.WriteLine($"evenNumbers containg {evenNumbers.Count} elements");
            DisplaySet(oddNumbers);


            HashSet<int> numbers = new HashSet<int>();
            Console.WriteLine("numbers UnionWith oddNumbers...");
            numbers.UnionWith(oddNumbers);

            Console.Write("numbers contains {0} elements: ", numbers.Count);
            DisplaySet(numbers);
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
