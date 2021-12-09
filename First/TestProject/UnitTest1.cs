using First;
using NUnit.Framework;

namespace TestProject
{

    /// <summary>
    /// Arrenge , Act , Asert 
    /// </summary>
    public class Tests
    {

        [OneTimeSetUp]
        public void SetupOneTime()
        {
            System.Console.WriteLine("I am running");
        }

        [OneTimeTearDown]
        public void TearDownTime()
        {
            System.Console.WriteLine("I am running");
        }

        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("I am running before");
        }


        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("I am running before");
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Abhay","abhay");
        }



        [Test]
        public void Test2()
        {
            Assert.AreEqual(200,198,3);
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(200, 197, 3);
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(200, 196, 3);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("ABhay","abhaY", "Name is not matched" );
        }


        [Test]
        public void Test7IStrue1()
        {
            Assert.IsTrue(2 > 4);
        }


        [Test]
        public void Test7IStrue2()
        {
            Assert.IsTrue(2 < 4);
        }


        [Test]
        public void Test7ISNotNull2()
        {
            User user = null;
            Assert.IsNotNull(user);
        }


        [Test]
        public void Test7ISNotNull3()
        {
            User user = new User();
            Assert.IsNotNull(user);
        }



        [Test]
        public void Test7ISNotNull4()
        {
            User user = new User();
            Assert.IsNotNull(user);
        }


        [Test]
        public void TestThat()
        {
            User user = new User();
            Assert.That("check", Is.EqualTo("check"));
        }



        [Test]
        public void TestLess()
        {
            User user = new User();
            Assert.Less(30, 4);
        }

        [Test]
        public void TestLess2()
        {
            User user = new User();
            Assert.Less(30, 40);
        }

        [Test]
        public void TestGreater()
        {
           
            Assert.Greater(30, 40);
        }


        
       


    }
}