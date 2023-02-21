using FindMaxGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxGenericsTest
{
    public class StringTest
    {
        [Test]
        public void MaximumString_WhenFirstGivenValueIsMax()
        {
            FindMaxGeneric<string> str = new FindMaxGeneric<string>("Peach", "Banana", "Apple");
            string result = str.FindMax();
            Assert.AreEqual("Peach", result);
            Assert.Pass();
        }
        [Test]
        public void MaximumString_WhenStringGivenValueIsMax()
        {
            FindMaxGeneric<string> str = new FindMaxGeneric<string>("Banana", "Peach", "Apple");
            string result = str.FindMax();         
            Assert.AreEqual("Peach", result);
            Assert.Pass();
        }
        [Test]
        public void MaximumString_WhenThirdGivenValueIsMax()
        {
            FindMaxGeneric<string> str = new FindMaxGeneric<string>("Banana", "Peach", "Zebra");
            string result = str.FindMax();
            Assert.AreEqual("Zebra", result);
            Assert.Pass();
        }
    }
}
