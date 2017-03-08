using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextJustification
{
    class Program
    {
        static void Main(string[] args)
        {
            TextJust obj = new TextJust();
            string[] words = { "Two", "words."}; // output shoud be {"Two words. "}
            //string[] words = { "This", "is", "an", "example", "of", "text", "justification."};
            int L = 11;
            var retWord = obj.textJustification(words, L);
            foreach (var item in retWord)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}




/*
    words = ["This", "is", "an", "example", "of", "text", "justification."]

    and L = 16, the output should be

    textJustification(words, L) = ["This    is    an",
                               "example  of text",
                               "justification.  "]
 */
