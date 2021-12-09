using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace com.refer
{

	

	public class Selenium_Example013_checkboxselection
	{
		WebDriver driver;

		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
		}


		[OneTimeTearDown]
		public void TestEnd()
		{
			driver.Close();
			driver.Quit();
			driver.Dispose();
		}


		[Test]
		public void launchBrowser()
		{
			driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

		}
		public void orangelogin()

		{
			IWebElement e = driver.FindElement(By.Id("txtUsername"));
			e.SendKeys("Admin");

			e = driver.FindElement(By.Id("txtPassword"));
			e.SendKeys("admin123");

			e = driver.FindElement(By.Id("btnLogin"));
			e.Click();




		}

		public void check()
		{

			IWebElement e = driver.FindElement(By.XPath("//*[@id='ohrmList_chkSelectAll']"));

			for (int i = 0; i < 2; i++)
			{

				if (!e.Selected)
				{

					e.Click();
					Console.WriteLine("Selected checkbox" + e.Selected);
				}

				else
				{
					e.Click();
					Console.WriteLine("Checkbox was selected:" + e.Selected);

				}
			}

		}
	}

}