using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

namespace com.refer
{

	 
	public class Selenium_Example017_WebTable
	{
	  WebDriver driver;

		[Test]
		public void Test(string[] args)
		{



			login();
			try
			{
				Thread.Sleep(5000);
			}
			catch (Exception e)
			{
				// TODO Auto-generated catch block
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}
			getelements();

		}




		public   void login()
		{
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/admin/viewSystemUsers");
			driver.Manage().Window.Maximize();
			IWebElement e = driver.FindElement(By.Id("txtUsername"));
			e.SendKeys("Admin");
			e = driver.FindElement(By.Id("txtPassword"));
			e.SendKeys("admin123");
			e = driver.FindElement(By.Name("Submit"));
			e.Click();


		}
		public  void getelements()
		{



			IWebElement e = driver.FindElement(By.XPath("//*[@id='resultTable']"));
			IList<IWebElement> rows = e.FindElements(By.TagName("tr"));
			int i = 0;
			foreach (IWebElement row in rows)
			{

				IList<IWebElement> columns = row.FindElements(By.TagName("td"));

				int j = 0;

				foreach (IWebElement column in columns)
				{


					if (i == 3 && j == 1)
					{


					  Console.Write(column.Text);
					}


					j++;

				}
				i++;
				Console.WriteLine("");
			}
		}

	}

}