using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsMultipleParams
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) =>
            {
                Console.WriteLine("Message: {0}, Result: {1}", msg, result);
            });

            m.Add(10, 10);
            Console.ReadLine();

            VerySimpleDelegate d = new VerySimpleDelegate(() => { return " Text"; });
            Console.WriteLine(d());
        }

        public delegate string VerySimpleDelegate();


        public class SimpleMath
        {
            public delegate void MathMessage(string msg, int result);
            private MathMessage mmDelgate;
            public void SetMathHandler(MathMessage target)
            {
                mmDelgate = target;
            }

            public void Add(int x, int y)
            {
                mmDelgate?.Invoke("Adding has completed!", x + y);
            }

        }
    }
}
