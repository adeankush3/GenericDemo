using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubleArray = { 1.2, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'a', 'b', 'c', 'd' };
            GenericDemo<double> demo = new GenericDemo<double>();
            GenericDemo<char> demo1 = new GenericDemo<char>();
            demo.Print(doubleArray);
            demo1.Print(charArray);
            Program.toPrint(doubleArray);
            Program.toPrint(charArray);
        }
        public static void toPrint(double[] inputArray)
        {
            foreach(double element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------");
        }
        public static void toPrint(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------");
        }

    }
}
