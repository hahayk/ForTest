using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoBot
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        string[] domainType(string[] domains)
        {
            Dictionary<string, string> domType = new Dictionary<string, string>();
            domType.Add("org", "organization");
            domType.Add("com", "commercial");
            domType.Add("net", "network");
            domType.Add("info", "information");

            string[] domainTypeValue = "";

            foreach (var domain in domains)
            {
                int lastDot = domain.LastIndexOf(".");
                domainTypeValue[0] += "";

            }

            return domains;
        }

        
        //    domtype ,
        //    
        //)
    }
}
