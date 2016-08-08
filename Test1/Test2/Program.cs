using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            // Fill the list by using the Add method
            foreach (int num in new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })
            {
                numbers.Add(num);
            }

            // Insert into the last position
            numbers.Insert(numbers.Count - 1, 99);

            // Remove first element whose value is 7
            numbers.Remove(7);

            // Remove the element at index 6
            numbers.RemoveAt(6);

            Console.WriteLine("Iterate using a for statement:");
            for (int i = 0; i < numbers.Count; i++)
            {
                int num = numbers[i];
                Console.WriteLine(num);
            }

            Console.WriteLine("Iterate using a foreach statement:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
