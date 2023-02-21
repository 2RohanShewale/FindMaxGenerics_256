using FindMaxGenerics;
namespace FindMaxGenericsTest
{
    public class DoubleTest
    {
        FindMaxGeneric doubleMax = new FindMaxGeneric();
        [Test]
        public void MaximumDouble_WhenFirstGivenValueIsMax()
        {
            double result = doubleMax.FindMaximum<double>(15.1, 11.03, 11.01);
            Assert.AreEqual(15.1, result);
            Assert.Pass();
        }
        [Test]
        public void MaximumDouble_WhenSecondGivenValueIsMax()
        {
            double result = doubleMax.FindMaximum<double>(15.1, 17.03, 11.01);
            Assert.AreEqual(17.03, result);
            Assert.Pass();
        }
    }
}
