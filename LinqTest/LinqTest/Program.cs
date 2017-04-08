using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int> { 10, 0, 3, 10, 10, 3, 4, 4, 4, 4, 4, 7 };

            var mode = lst.GroupBy(i => i)
                        .OrderBy(group => group.Count())
                        .Select(group => group.Key);
                        //.FirstOrDefault();

            int k = 0;

        }

    
    }
}
