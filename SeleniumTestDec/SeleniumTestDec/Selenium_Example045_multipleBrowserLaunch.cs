using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace com.refer
{
	public class Selenium_Example045_multipleBrowserLaunch
	{

        [TestFixture(typeof(FirefoxDriver))]
        [TestFixture(typeof(ChromeDriver))]
        public class SkillTest<TWebDriver> where TWebDriver : IWebDriver, new()
        {
            private IWebDriver driver;
            private string driverPath;

            [SetUp]
            public void Init()
            {
                driver = new TWebDriver();
                driver.Navigate().GoToUrl("https://google.com");
            }

            [Test]
            public void your_test_case()
            {
                
            }


            [TearDown]
            public void CleanUp()
            {
                driver.Quit();
                driver.Dispose();
            }
        }

    }

}