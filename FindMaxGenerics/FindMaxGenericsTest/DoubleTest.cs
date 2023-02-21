using FindMaxGenerics;
namespace FindMaxGenericsTest
{
    public class DoubleTest
    {
        FindMaxGeneric doubleMax = new FindMaxGeneric();
        [Test]
        public void MaximumInt_WhenFirstGivenValueIsMax()
        {
            double result = doubleMax.FindMaximum<double>(13.1, 11.03, 11.01);
            Assert.AreEqual(13.1, result);
            Assert.Pass();
        }
    }
}
