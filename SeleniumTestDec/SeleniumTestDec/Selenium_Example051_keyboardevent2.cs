using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace com.refer
{
	public class Selenium_Example051_keyboardevent2
	{
		WebDriver driver;

		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();

			driver.Navigate().GoToUrl("http://www.google.com");
			driver.Manage().Window.Maximize();
		}


	[Test]
		public void keyboarevent()
		{

			IWebElement e = driver.FindElement(By.LinkText("Gmail"));
			Actions act = new Actions(driver);

			act.MoveToElement(e);
			Thread.Sleep(2000);
			act.ContextClick(e).SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Build().Perform();
			Thread.Sleep(10000);
		}
		

		
	}

}