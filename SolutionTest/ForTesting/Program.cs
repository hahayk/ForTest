using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace Translate
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void IterateThurDictionary()
        {
            Dictionary<string, Element> elements = BuildDictionary();
            foreach (KeyValuePair<string, Element> kvp in elements)
            {
                Element theElement = kvp.Value;
                Console.WriteLine($"key: {kvp.Key}");
                Console.WriteLine($"values: {theElement.Symbol} {theElement.Name} {theElement.AtomicNumber}");
            }
        }

        public static Dictionary<string, Element> BuildDictionary()
        {
            return new Dictionary<string, Element>
    {
        {"K",
            new Element() { Symbol="K", Name="Potassium", AtomicNumber=19}},
        {"Ca",
            new Element() { Symbol="Ca", Name="Calcium", AtomicNumber=20}},
        {"Sc",
            new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
        {"Ti",
            new Element() { Symbol="Ti", Name="Titanium", AtomicNumber=22}}
    };

        }

        private static void AddToDictionary(Dictionary<String, Element> elements,
            string symbol, string name, int atomicNumber)
        {
            Element theElement = new Element();
            theElement.Symbol = symbol;
            theElement.Name = name;
            theElement.AtomicNumber = atomicNumber;
            elements.Add(key: theElement.Symbol, value: theElement);
        }



    }

    public class Element
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int AtomicNumber { get; set; }
    }
}
