using First;
using NUnit.Framework;
using QdnSeleniumDriver;

namespace TestProject
{

    /// <summary>
    /// Arrenge , Act , Asert 
    /// </summary>
    public class TestOrangeHrmLogin
    {
        QDNDriver qDNDriver;

        [OneTimeSetUp]
        public void Setup()
        {
            //Arrenge 
            qDNDriver = new QDNDriver();
        }



        [Order(1)]
        [Test]
        
        public void CheckTitle()
        {
            //Act 
            qDNDriver.WebDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            qDNDriver.WebDriver.Manage().Window.Maximize();

            string title= qDNDriver.WebDriver.Title;
            Assert.AreEqual("OrangeHRM", title);
        }

        [Order(2)]
        [Test]
       
        public void CheckEmptyUserName()
        {
            //Arrange 
            LoginPage loginPage = new LoginPage(qDNDriver.WebDriver);
            loginPage.Submit();


            Assert.AreEqual("Username cannot be empty", loginPage.GetMessage(qDNDriver.WebDriver));
        }



        [Order(3)]
        [Test]

        public void CheckEmptyPassword()
        {
            //Arrange 
            LoginPage loginPage = new LoginPage(qDNDriver.WebDriver);
            loginPage.SetUserName("admin");
            loginPage.Submit();


            Assert.AreEqual("Password cannot be empty1", loginPage.GetMessage(qDNDriver.WebDriver));
        }





    }
}