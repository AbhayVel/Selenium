using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V85.SystemInfo;
using System;

namespace com.refer
{
	
	public class Selenium_Example039_SetDimension
	{
		WebDriver driver;

		[OneTimeSetUp]
		public void Setup()
		{
		
			driver = new ChromeDriver();
			Console.WriteLine(driver.Manage().Window.Size);

			var size = driver.Manage().Window.Size;
			size.Width = 480;
			size.Height = 900;
			driver.Manage().Window.Size = size;
			Console.WriteLine(driver.Manage().Window.Size);
		}


		[Test]
		public void launchBrowser()
		{
			driver.Navigate().GoToUrl("http://quickitdotnet.co.in/");
			


		
		}

	}

}