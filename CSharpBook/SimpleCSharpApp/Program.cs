using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowEnvironmentDetails();
            FormatNumericalData();
            DisplayMessage();
            ParseFromStrings();
            FunWithStringBuilder();

            Console.ReadLine();
        }

        static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
        }

        static void FormatNumericalData()
        {
            int val = 99999;

            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", val);
            Console.WriteLine("d9 format: {0:d9}", val);
            Console.WriteLine("f3 format: {0:f3}", val);
            Console.WriteLine("n format: {0:n}", val);
            Console.WriteLine("E format: {0:E}", val);
            Console.WriteLine("e format: {0:e}", val);
            Console.WriteLine("X format: {0:X}", val);
            Console.WriteLine("x format: {0:x}", val);
        }

        static void DisplayMessage()
        {
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);

            System.Windows.MessageBox.Show(userMessage);
        }

        static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type parsing:");

            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);

            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);

            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);

            char c = char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);

            Console.WriteLine();
        }

        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");

            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());

            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());

            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }
    }
}
