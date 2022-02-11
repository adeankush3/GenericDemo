using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricDemo
{
    public class GenericDemo <T>
    {
        public void Print(T[] array)
        {
            foreach(T item in array)
            {
                Console.WriteLine(item);
            }
        }

    }
}
