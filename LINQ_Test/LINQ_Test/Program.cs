using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Books > bks = new List<Books>();
            bks.Add(new Books("Book1", 100, "Genre1", 1999 ));
            bks.Add(new Books("Book2", 100, "Genre2", 2016));
            bks.Add(new Books("Book3", 23300, "Genre3", 1999 ));
            bks.Add(new Books("Book4", 300, "Genre2", 2017 ));
            bks.Add(new Books("Book5", 45000, "Genre2", 1555 ));
            bks.Add(new Books("Book5", 5400, "Genre2", 1555 ));
            bks.Add(new Books("Book5", 45000, "Genre2", 1555 ));

            //get books which genre contains 2
            var bookByGenre = from book in bks
                              where book.Genre.Contains("2")
                              select book;
            foreach (var item in bookByGenre)
            {
                //Console.WriteLine(item);
            }

            //get sum of books that are published after 1999
            var bookPriceByYear = (from book in bks
                                   where book.Year > 1999
                                   select book.Price).Sum();
            //Console.WriteLine($"Summary Price is: {bookPriceByYear}");

            //show books price summary by published year
            var bookGroupBy = from book in bks
                               group book.Price by book.Name into bPr
                               select new { Price = bPr.Key, NAME = bPr.ToString()};

            foreach (var item in bookGroupBy)
            {   
                Console.WriteLine(item);
            }
        }
    }
}
