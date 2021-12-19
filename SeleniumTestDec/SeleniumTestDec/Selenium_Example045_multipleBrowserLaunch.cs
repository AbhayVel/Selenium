using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace com.refer
{
	 
        [TestFixture(typeof(ChromeDriver))]
        public class SkillTest<TWebDriver> where TWebDriver : IWebDriver, new()
        {
            private IWebDriver driver;
           // private string driverPath="";

            [OneTimeSetUp]
            public void Init()  
            {
                driver = new TWebDriver();
                
            }

            [Test]
            public void your_test_case()
            {
                driver.Navigate().GoToUrl("https://google.com");
            }


            [TearDown]
            public void CleanUp()
            {
                driver.Quit();
                driver.Dispose();
            }
        }

    }

 