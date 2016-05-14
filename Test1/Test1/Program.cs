using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pins = { 9, 3, 7, 2 };

            foreach (int pin in pins)
            {
                Console.WriteLine(pin);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
