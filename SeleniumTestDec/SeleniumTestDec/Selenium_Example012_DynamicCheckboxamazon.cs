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
		public void verifycheckbox(string displayText)
		{

			IWebElement searchbox = driver.FindElement(By.Id("twotabsearchtextbox"));
				searchbox.SendKeys("Mobiles");
			IWebElement checkbox = driver.FindElement(By.XPath("//li[@aria-label='" + displayText + "']//input"));

			IWebElement checkboxi = checkbox.FindElement(By.XPath("//li[@aria-label='" + displayText + "']//i"));

			bool state = checkboxi.Selected;

			Console.WriteLine("Checkbox is not checked" + " : " + state);
			if (!state)
			{
				checkboxi.Click();

			}
		}
	

	
	}

}