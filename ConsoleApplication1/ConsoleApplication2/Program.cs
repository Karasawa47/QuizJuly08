using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stuff = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            var first5stuff = ReturnFirstFive(stuff);
            foreach (var x in first5stuff)
            {
                Console.WriteLine(x + "");
            }
            Console.ReadKey();
        }
        static IEnumerable<T> ReturnFirstFive<T>(IEnumerable<T> aList)
        {
            var newList = aList.Take(5);
            return newList;
        }
    }
}
