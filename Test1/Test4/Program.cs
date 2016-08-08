using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ages = new Dictionary<string, int>();

            // Fill up the dictionary
            ages.Add("John", 47);
            ages.Add("Diana", 46);
            ages["James"] = 20;
            ages["Francesca"] = 18;

            Console.WriteLine("The dictionary contains:");
            foreach (KeyValuePair<string, int> element in ages)
            {
                string name = element.Key;
                int age = element.Value;
                Console.WriteLine("Name: {0}, Age: {1}", name, age);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
