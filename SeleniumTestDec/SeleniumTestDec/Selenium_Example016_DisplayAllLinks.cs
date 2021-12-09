using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace com.refer
{

	public class Selenium_Example016_DisplayAllLinks
	{


		WebDriver driver;
		[SetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
              driver.Manage().Window.FullScreen();
		}

		[Test]
		public  void getAllLinks( )
		{

			IList<IWebElement> Links = (IList<IWebElement>)driver.FindElements(By.TagName("a"));
			foreach (IWebElement getlink in Links)
			{
			Console.WriteLine(getlink.GetAttribute("href"));
			}

		}

		public  void login(WebDriver driver)
		{
			IWebElement e = driver.FindElement(By.Id("txtUsername"));
			e.SendKeys("Admin");
			e = driver.FindElement(By.Id("txtPassword"));
			e.SendKeys("admin123");
			e = driver.FindElement(By.Name("Submit"));
			e.Click();


		}




	}



}