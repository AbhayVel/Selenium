using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace com.refer
{


	public class Selenium_Example011_Radio_isdisabled
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
		[Order(1)]
		public void launchBrowser()
		{
			driver.Navigate().GoToUrl("https://www.quickitdotnet.co.in/practice-project");

		}

		[Test]
		[Order(2)]
		public  void radio()
		{

			Thread.Sleep(2000);
			// As we can see, all the radio buttons are being created using the HTML tag <input> and have an attribute named "type", 
			//which has a value "radio", which signifies that the type of the input element is a radio button.

			//Now, let's see how we can locate and perform specific actions on the Radion Buttons using Selenium WebDriver?
			  IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
			  js.ExecuteScript("window.scrollBy(0,1000)");
			  
			IWebElement otherradio = driver.FindElement(By.CssSelector("#post-2695 > div > div > div.col-md-6.offset-md-3.mt-5 > div:nth-child(8) > form > div:nth-child(3) > label > input"));
			Thread.Sleep(2000);
			//verify the button's disabled property

			if (otherradio.Enabled)
			{
				Console.WriteLine("Other button is enabled");

			}
			else
			{
				Console.WriteLine("Other button is disabled");
			}
			Thread.Sleep(2000);
			Assert.IsTrue(!otherradio.Enabled, "Other button is disabled");

		}
	}
}