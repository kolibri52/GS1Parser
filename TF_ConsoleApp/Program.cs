using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GS1Parser_dotnet;

namespace TF_ConsoleApp
{
    class Program
    {
        // Console Test App, just for quick testing purposes
        static void Main(string[] args)
        {            
            string description = "";
            var parser = new GS1Parser();

            // set a test content
            string code = "0101234567890128112309152109876543" + (char)29 + "80121.18.3" + (char)29;
            code = code.Replace('@', (char)29); //to get fnc1

            // parse the test content
            var result = parser.Parse(code);

            // return each element of the GS1 Code to console
            foreach (KeyValuePair<string, string> item in result)
            {
                Console.WriteLine("AI: {0} ({1}), Value: {2}", item.Key, parser.GetGS1Dict()[item.Key].Description, item.Value);
            }

            Console.ReadLine();
        }
    }
}
