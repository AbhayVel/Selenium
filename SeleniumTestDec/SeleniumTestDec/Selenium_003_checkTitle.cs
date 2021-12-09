using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTestDec
{
     
    public class checkTitle
    {

        WebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

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
            IWebElement e = driver.FindElement(By.XPath("//*[@id='logInPanelHeading']"));


            string title = e.Text;


            
            if (title.Equals("Login paneL", System.StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Title is present");
            }
            else
            {
                Console.WriteLine("Error: Invalid Title");
            }
            Assert.AreEqual("Login paneL", title, "Error: Invalid Title");


        }
    

    
}
}