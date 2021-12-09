using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace com.refer
{


	public class Selenium_Example009_mousemove
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
		public void login()

		{
			IWebElement e = driver.FindElement(By.Id("txtUsername"));
			e.SendKeys("Admin");
			e = driver.FindElement(By.Id("txtPassword"));
			e.SendKeys("admin123");
			e = driver.FindElement(By.Name("Submit"));
			e.Click();

		}


		[Test]
		[Order(2)]
		public  void movemouse()
		{
			IWebElement e = driver.FindElement(By.XPath("//*[@id='menu_admin_Job']"));
			Actions act = new Actions(driver);

			act.MoveToElement(e).Build().Perform();
			act.Click();
			e = driver.FindElement(By.LinkText("Job Titles"));
			act.MoveToElement(e).Build().Perform();
			e.Click();


		}


	}





	}

