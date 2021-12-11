using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

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
		[Order(1)]
		public void launchBrowser()
		{
			driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

		}

		[Test]
		[Order(2)]
		public void orangelogin()

		{
			IWebElement e = driver.FindElement(By.Id("txtUsername"));
			e.SendKeys("Admin");

			e = driver.FindElement(By.Id("txtPassword"));
			e.SendKeys("admin123");

			e = driver.FindElement(By.Id("btnLogin"));
			e.Click();




		}

		[Test]
		[Order(3)]
		public void check()
		{
			driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/admin/viewSystemUsers");
			//
			Thread.Sleep(4000);
			IWebElement e = driver.FindElement(By.XPath("//*[@id='ohrmList_chkSelectAll']"));

			for (int i = 0; i < 2; i++)
			{
				Thread.Sleep(8000);
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

			Thread.Sleep(8000);

		}
	}

}