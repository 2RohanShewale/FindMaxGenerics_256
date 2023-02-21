using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            FindMax stringLast = new FindMax();
            Console.WriteLine($"string : {stringLast.FindMaximum("Banana", "Peach", "Apple")}");
            Console.ReadKey();
        }
    }
}
