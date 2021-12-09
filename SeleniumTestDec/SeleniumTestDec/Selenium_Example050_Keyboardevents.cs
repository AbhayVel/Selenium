using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;

namespace com.refer
{
	

	public class Selenium_Example050_Keyboardevents
	{
		WebDriver driver;

		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();

			driver.Navigate().GoToUrl("http://www.google.com");
			driver.Manage().Window.Maximize();
			driver.SwitchTo().Frame(0);
		}

	

		[Test]
		public  void clickHold( )
		{
			Actions act = new Actions(driver);
			act.KeyDown(Keys.Control);
			IList<IWebElement> L = (IList<IWebElement>)driver.FindElement(By.CssSelector("ol#selectable"));
			Console.WriteLine(L.Count);
			act.Click(L[3]);
			act.Click(L[4]);
			act.KeyUp(Keys.Control);
			act.Build().Perform();
		}

	}

}