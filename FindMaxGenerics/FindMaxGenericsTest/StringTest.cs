﻿using FindMaxGenerics;
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
    }
}