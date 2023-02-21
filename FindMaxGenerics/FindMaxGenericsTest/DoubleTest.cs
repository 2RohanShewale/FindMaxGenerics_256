using FindMaxGenerics;
namespace FindMaxGenericsTest
{
    public class DoubleTest
    {
        [Test]
        public void MaximumDouble_WhenFirstGivenValueIsMax()
        {
            FindMaxGeneric<double> doubleMax = new FindMaxGeneric<double>(15.1, 11.03, 11.01);
            double result = doubleMax.FindMax();
            Assert.AreEqual(15.1, result);
            Assert.Pass();
        }
        [Test]
        public void MaximumDouble_WhenSecondGivenValueIsMax()
        {
            FindMaxGeneric<double> doubleMax = new FindMaxGeneric<double>(15.1, 17.03, 11.01);
            double result = doubleMax.FindMax();
            Assert.AreEqual(17.03, result);
            Assert.Pass();
        }
        [Test]
        public void MaximumDouble_WhenThirdGivenValueIsMax()
        {
            FindMaxGeneric<double> doubleMax = new FindMaxGeneric<double>(15.1, 17.03, 20.01);
            double result = doubleMax.FindMax();
            Assert.That(result, Is.EqualTo(20.01));
            Assert.Pass();
        }
    }
}
