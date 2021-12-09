using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTestDec
{
    public class login
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
    }
}
