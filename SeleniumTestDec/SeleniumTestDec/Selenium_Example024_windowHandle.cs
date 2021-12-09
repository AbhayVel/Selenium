using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace com.refer
{

 
	public class Selenium_Example024_windowHandle
	{
	  WebDriver driver;
		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("https://www.kotak.com/en/home.html");
		}

		[Test]
		public  void WindowHandles()
		{
			 
			
			IWebElement login = driver.FindElement(By.XPath("//span[contains(text(),'Login')]"));
			login.Click();
			 
			ISet<string> handles = (ISet<string>)driver.WindowHandles;
			foreach (string handle in handles)
			{
				Console.WriteLine(handle);
			}

		}

	 
	}

}