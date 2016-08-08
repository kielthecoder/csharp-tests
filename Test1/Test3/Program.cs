using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();

            // Fill the list by using the AddFirst method
            foreach (int num in new int[] { 10, 8, 6, 4, 2 })
            {
                numbers.AddFirst(num);
            }

            Console.WriteLine("Iterating using a for loop:");
            for (LinkedListNode<int> n = numbers.First; n != null; n = n.Next)
            {
                Console.WriteLine(n.Value);
            }

            Console.WriteLine("Iterating using a foreach loop:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
