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
            FindMaxGeneric<int> intMax = new FindMaxGeneric<int>(10, 20, 30);
            FindMaxGeneric<double> doubleMax = new FindMaxGeneric<double>(10.4, 20.3, 30.2);
            FindMaxGeneric<string> strMax = new FindMaxGeneric<string>("Banana", "Peach", "Apple");

            Console.WriteLine($"Max Int: {intMax.FindMax()} ");
            Console.WriteLine($"Max double: {doubleMax.FindMax()} ");
            Console.WriteLine($"Max string: {strMax.FindMax()} ");

            Console.ReadKey();
        }
    }
}
