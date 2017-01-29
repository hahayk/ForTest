using System;

namespace SimpleImplementationOfLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleLinkedList li = new SimpleLinkedList();
            li.AddLast("Zero");
            li.AddFirst("First");
            li.AddFirst("Second");
            li.AddFirst("Third");
            li.AddLast("Forth");

            Console.WriteLine(li.ToString());
        }
    }
}
