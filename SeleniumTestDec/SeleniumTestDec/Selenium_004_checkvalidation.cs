using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTestDec
{
    public class checkvalidation
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
        public void verifyTitle()


        {


            IWebElement e = driver.FindElement(By.XPath("//*[@id='btnLogin']"));
            e.Click();
            e = driver.FindElement(By.XPath("//*[@id='spanMessage']"));
            string title = e.Text;
            if (title.Equals("Username cannot be empty"))
            {
                Console.WriteLine("Validation appeared saying Username cannot be empty");
            }
            else
            {
                Console.WriteLine("Error: Sorry validation does not match");
            }
            Assert.AreEqual("Username cannot be empty", title, "Error: Sorry validation does not match");
        }




    }
}
