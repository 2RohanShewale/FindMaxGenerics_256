using FindMaxGenerics;
namespace FindMaxGenericsTest
{
    public class IntTests
    {

        [Test]
        public void MaximumInt_WhenFirstGivenValueIsMax()
        {
            FindMaxGeneric<int> intMax = new FindMaxGeneric<int>(11, 10, 9);
            int result = intMax.FindMax();
            Assert.AreEqual(11, result);
            Assert.Pass();
        }
        [Test]
        public void MaximumInt_WhenSecondGivenValueIsMax()
        {
            FindMaxGeneric<int> intMax = new FindMaxGeneric<int>(11, 12, 9);
            int result = intMax.FindMax();
            Assert.AreEqual(12, result);
            Assert.Pass();
        }
        [Test]
        public void MaximumInt_WhenThirdGivenValueIsMax()
        {
            FindMaxGeneric<int> intMax = new FindMaxGeneric<int>(11, 12, 13);
            int result = intMax.FindMax();
            Assert.AreEqual(13, result);
            Assert.Pass();
        }
    }
}