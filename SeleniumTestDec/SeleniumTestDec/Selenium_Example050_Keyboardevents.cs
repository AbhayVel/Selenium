using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Threading;

namespace com.refer
{
	

	public class Selenium_Example050_Keyboardevents
	{
		WebDriver driver;

		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();

			driver.Navigate().GoToUrl("http://jqueryui.com/autocomplete/");
			driver.Manage().Window.Maximize();
			IWebElement frame1 = driver.FindElement(By.ClassName("demo-frame"));
			driver.SwitchTo().Frame(frame1);
			Thread.Sleep(3000);

		}

	

		[Test]
		public  void clickHold( )
		{
			IWebElement tags = driver.FindElement(By.XPath("//input[@class='ui-autocomplete-input']"));
			tags.SendKeys("c");

			Actions act = new Actions(driver);
			act.KeyDown(Keys.ArrowDown);
			act.Build().Perform();
			 
			Thread.Sleep(2000);
			 

			Thread.Sleep(2000);
		}

	}

}