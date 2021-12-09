using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

namespace com.refer
{

 

	public class Selenium_Example014_Dropdown_Approach5
	{
		 WebDriver driver;

		 

		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/components/dropdowns/");
			driver.Manage().Window.Maximize();
		}

		[Test]
		public void Test(string[] args)
		{
			

			
		 
			IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
			js.ExecuteScript("window.scrollBy(0,350)", "");

			IWebElement dropDownButton = driver.FindElement(By.Id("dropdownMenuButton"));

			dropDownButton.Click();
			try
			{
				Thread.Sleep(100);
			}
			catch (Exception e)
			{
				// TODO Auto-generated catch block
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}

			IList<IWebElement> list = (IList<IWebElement>)driver.FindElements(By.XPath("//div[@class='dropdown-menu show' and @aria-labelledby='dropdownMenuButton']/a"));
 
			Console.WriteLine(list.Count);
			for (int i = 0; i < list.Count; i++)
			{
				Console.WriteLine(list[i].Text);
			}
			for (int i = 0; i < list.Count; i++)
			{

				if (list[i].Text.Equals("Another action"))
				{
					list[i].Click();
					break;
				}
			}
		}
	}

}