using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

namespace com.refer
{

	public class Selenium_Example048_autosuggest
	{
		WebDriver driver;

		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();

			driver.Navigate().GoToUrl("http://jqueryui.com/autocomplete/");
			driver.Manage().Window.Maximize();
			driver.SwitchTo().Frame(0);
		}



		public void keyup()
		{

			IWebElement tags = driver.FindElement(By.XPath("//input[@class='ui-autocomplete-input']"));
			tags.SendKeys("c");


			IWebElement we = driver.FindElement(By.Id("ui-id-1"));
			IList<IWebElement> wel = (IList<IWebElement>)we.FindElements(By.TagName("li"));
			Console.WriteLine(wel.Count);
			wel[2].Click();
		}
	}
}



