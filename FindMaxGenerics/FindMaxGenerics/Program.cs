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
            FindMax intMax = new FindMax();
            Console.WriteLine($"Maximum Int : {intMax.FindMaximum(40,50,60)}");
            Console.ReadKey();
        }
    }
}
