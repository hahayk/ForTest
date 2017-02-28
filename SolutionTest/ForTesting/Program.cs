using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Translate
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static Dictionary<string, Element> BuildDictionary()
        {
            var elements = new Directory<string, Element>();

        }

        private static void AddToDictionary(Dictionary<String, Element> elements,
            string symbol, string name, int atomicNumber)
        {
            Element theElement = new Element();
            theElement.Symbol = symbol;
            theElement.Name = name;
            theElement.AtomicNumber = atomicNumber;
            elements.Add(ConsoleKey: theElement.Symbol, value: theElement);
        }

    }

    public class Element
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int AtomicNumber { get; set; }
    }
}
