using FindMaxGenerics;
namespace FindMaxGenericsTest
{
    public class Tests
    {
        FindMaxGeneric intMax = new FindMaxGeneric();

        [Test]
        public void MaximumInt_WhenFirstGivenValueIsMax()
        {
            int result = intMax.FindMaximum<int>(11,10,9);
            Assert.AreEqual(11, result);
            Assert.Pass();
        }
        [Test]
        public void MaximumInt_WhenSecondGivenValueIsMax()
        {
            int result = intMax.FindMaximum<int>(11, 12, 9);
            Assert.AreEqual(12, result);
            Assert.Pass();
        }
        [Test]
        public void MaximumInt_WhenThirdGivenValueIsMax()
        {
            int result = intMax.FindMaximum<int>(11, 12, 13);
            Assert.AreEqual(13, result);
            Assert.Pass();
        }
    }
}