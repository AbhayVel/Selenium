using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTestDec
{
    public class checkwelcome
    {

        WebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }


        [OneTimeTearDown]
        public void TestEnd()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }


        [Test]
        public void launchBrowser()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

        }

        [Test]
        public void orangelogin()

        {
            IWebElement e = driver.FindElement(By.Id("txtUsername"));
            e.SendKeys("Admin");

            e = driver.FindElement(By.Id("txtPassword"));
            e.SendKeys("admin123");

            e = driver.FindElement(By.Id("btnLogin"));
            e.Click();





        }
        [Test]
        public void welcomemessage() {

            IWebElement e = driver.FindElement(By.XPath("//*[@id='welcome']"));
            string welcome = e.Text;
            if (welcome.Equals("welcome Admin", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Welcome Admin text is available");
            }
            else
            {
                Console.WriteLine("Error: Welcome Admin Text is not available");
            }

            Assert.AreEqual("Welcome Admin", welcome, "Error: Welcome Admin Text is not available");
        }
    }
}
