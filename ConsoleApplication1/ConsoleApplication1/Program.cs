using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] anArray = { 1, 4, 5, 8, 3, 3, 7, 3, 6, 6 };
            DisplayArray(anArray);
            Console.ReadKey();
        }
        static void DisplayArray(int[] array)
        {
            for (int i=0;i<array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(array[i]+"");
                }
            }
        }
    }
}
