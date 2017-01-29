using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Test
{
    class Books
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }


        public Books(string name, int price, string genre, int year)
        {
            Name = name;
            Price = price;
            Genre = genre;
            Year = year;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Genre: {Genre}, Year: {Year}";
        }

    }
}
