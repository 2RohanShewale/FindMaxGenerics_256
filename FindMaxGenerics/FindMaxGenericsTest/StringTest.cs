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
        FindMaxGeneric str = new FindMaxGeneric();
        [Test]
        public void MaximumString_WhenFirstGivenValueIsMax()
        {
            string result = str.FindMaximum<string>("Peach", "Banana", "Apple");
            Assert.AreEqual("Peach", result);
            Assert.Pass();
        }
        [Test]
        public void MaximumString_WhenStringGivenValueIsMax()
        {
            string result = str.FindMaximum<string>("Banana", "Peach", "Apple");
            Assert.AreEqual("Peach", result);
            Assert.Pass();
        }
        [Test]
        public void MaximumString_WhenThirdGivenValueIsMax()
        {
            string result = str.FindMaximum<string>("Peach", "Banana", "Zebra");
            Assert.AreEqual("Zebra", result);
            Assert.Pass();
        }
    }
}
