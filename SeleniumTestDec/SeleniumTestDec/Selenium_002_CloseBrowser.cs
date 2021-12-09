using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestDec
{
    public class closeBrowser
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void closebrowser()
        {
         WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            driver.Close();
        }
    }
}