using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambdas *****\n");
            TraditionalDelegateSyntax();
            Console.ReadLine();
        }
        static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            Predicate<int> callback = IsEvenNumber;
            //List<int> evenNumbers = list.FindAll(callback);
            //            List<int> evenNumbers = list.FindAll(delegate(int i)
            //{
            //return (i % 2) == 0;
            //});
            List<int> evenNumbers = list.FindAll(i =>
            {
                Console.WriteLine("value of i is currently: {0}", i);
                bool isEven = ((i % 2) == 0);
                return isEven;
            });

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine($"{evenNumber}\t");
            }
            Console.WriteLine();
        }

        private static bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;
        }

    }
}
