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
            FindMax doubleMax = new FindMax();
            Console.WriteLine($"Maximum Int : {doubleMax.FindMaximum(40.4,50.4,60.5)}");
            Console.ReadKey();
        }
    }
}
