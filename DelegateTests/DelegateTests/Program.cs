using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTests
{
    public delegate int BinaryOp(int x, int y);
    public class SimpleMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Substract(int x, int y)
        {
            return x - y;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");

            BinaryOp b = new BinaryOp(SimpleMath.Add);
            Console.WriteLine($"10 + 10 is {b(10, 10)}");
        }
    }
}
