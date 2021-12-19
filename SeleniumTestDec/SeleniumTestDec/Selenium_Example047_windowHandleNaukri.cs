using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace com.refer
{
	

	public class Selenium_Example047_windowHandleNaukri
	{
		WebDriver driver;

		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			
			driver.Navigate().GoToUrl("http://naukri.com");
			driver.Manage().Window.Maximize();
		}
		[Test]
		public  void handlewindows()
		{
			// Store the parent window into a variable for further use 
			String parentWindowHandle = driver.CurrentWindowHandle;
			Console.WriteLine("Parent window's handle -> " + parentWindowHandle);

			//IWebElement clickElement = driver.FindElement(By.Id("button1"));
			////I am using 'for' loop to get multiple windows by clicking the element
			//for (var i = 0; i < 3; i++)
			//{
			//	clickElement.Click();
			//	Thread.Sleep(3000);
			//}

			

			List<string> lstWindow = driver.WindowHandles.ToList();
			String lastWindowHandle = "";
			foreach (var handle in lstWindow)
			{
				Console.WriteLine("Switching to window - > " + handle);
				Console.WriteLine("Navigating to google.com");

				//Switch to the desired window first and then execute commands using driver
				driver.SwitchTo().Window(handle);

				driver.Navigate().GoToUrl("https://google.com");
				lastWindowHandle = handle;
			}

			//Switch to the parent window
			driver.SwitchTo().Window(parentWindowHandle);

			//close the parent window
			driver.Close();

			//at this point there is no focused window, we have to explicitly switch back to some window.
			driver.SwitchTo().Window(lastWindowHandle);

			driver.Navigate().GoToUrl( "https://naukri.co.in");
		}
	}

}