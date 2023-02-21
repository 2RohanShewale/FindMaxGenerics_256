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
            FindMaxGeneric intMax = new FindMaxGeneric();
            FindMaxGeneric doubleMax = new FindMaxGeneric();
            FindMaxGeneric strMax = new FindMaxGeneric();

            Console.WriteLine($"Max Int: {intMax.FindMaximum(10,20,30)} ");
            Console.WriteLine($"Max double: {doubleMax.FindMaximum(10.4, 20.3, 30.2)} ");
            Console.WriteLine($"Max string: {strMax.FindMaximum("Banana", "Peach", "Apple")} ");

            Console.ReadKey();
        }
    }
}
