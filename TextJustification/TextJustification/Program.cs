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
            //string[] words = { "This", "is" };
            string[] words = { "This", "is", "an", "example", "of", "text", "justification."};
            int L = 16;
            var retWord = obj.textJustification(words, L);
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
