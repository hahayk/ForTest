﻿using System;

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

        public float Division(int x, int y)
        {
            return x / y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");

            Delegate DV

            SimpleMath sm = new SimpleMath();
            sm.Division += 

            Car c1 = new Car("SlugBug", 100, 10);
            c1.RegisterWithCarEngine(OnCarEngineEvent);
            c1.RegisterWithCarEngine(OnCarEngineEvent2);

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
                Console.ReadLine();
            }
        }

        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n"); 
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }

    }
}
