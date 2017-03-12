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
            //string[] words = {"a", "b", "c", "d", "e"}; // output is "a", "b", "c", "d", "e", "e"
           // string[] words = { "Two", "words."}; // output shoud be {"Two words. "}
            string[] words = { "Given",
            "an", 
 "array", 
 "of", 
 "words", 
 "and", 
 "a", 
 "length"};
            int L = 9;
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
