using First;
using NUnit.Framework;

namespace TestProject
{

    /// <summary>
    /// Arrenge , Act , Asert 
    /// </summary>
    public class TestCalc
    {

        [TestCase(1, 2)]
        [TestCase(4, 5)]
        [TestCase(7, 8)]
        [TestCase(23, 56)]
        [TestCase(97, 98)]
        public void Cal(int x, int y)
        {

            Assert.AreEqual(1, y - x);
        }


        [Test]
        public void Cal2([Values(1,40,7)]int x, [Values(2, 41, 8)] int y)
        {

            Assert.AreEqual(1, y - x);
        }



    }
}