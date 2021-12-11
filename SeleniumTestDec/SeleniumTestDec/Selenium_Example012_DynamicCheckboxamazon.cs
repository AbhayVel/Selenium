using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace com.refer
{
	

	public class Selenium_Example012_DynamicCheckboxamazon
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
			driver.Navigate().GoToUrl("https://www.amazon.co.in");

		}
		[Test]
		[TestCase("Get It in 2 Days", "Get It by Tomorrow")]
		//[TestCase("Get It by Tomorrow")]
		public void verifycheckbox(string displayText, string displayText2)
		{

			IWebElement searchbox = driver.FindElement(By.Id("twotabsearchtextbox"));
				searchbox.SendKeys("Mobiles" );

			IWebElement searchbutton= driver.FindElement(By.Id("nav-search-submit-button"));
			searchbutton.Click();
			Thread.Sleep(1000);
			IWebElement checkbox = driver.FindElement(By.XPath("(//li[@aria-label='" + displayText + "'])//input"));
			Thread.Sleep(3000);
			IWebElement checkboxi = driver.FindElement(By.XPath("(//li[@aria-label='" + displayText + "'])//i"));
			checkboxi.Click();
			Thread.Sleep(7000);
			IWebElement checkboxi2 = driver.FindElement(By.XPath("(//li[@aria-label='" + displayText2 + "'])//i"));
			checkboxi2.Click();


			Thread.Sleep(7000);
			checkboxi2 = driver.FindElement(By.XPath("(//li[@aria-label='" + displayText2 + "'])//i"));
			bool state = checkboxi2.Selected;

			Assert.IsTrue(!state, "Display text is selected");
			Console.WriteLine("Checkbox is not checked" + " : " + state);
			if (!state)
			{
				//checkboxi.Click();

			}

			Thread.Sleep(3000);
		}
	

	
	}

}