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
			driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

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
            try
            {
				Thread.Sleep(2000);
				Actions act = new Actions(driver);
				Thread.Sleep(2000);
				IWebElement admin = driver.FindElement(By.XPath("//*[@id='menu_admin_viewAdminModule']"));

				act.MoveToElement(admin).Build().Perform();
				Thread.Sleep(1000);
					

				IWebElement e = driver.FindElement(By.XPath("//*[@id='menu_admin_Job']"));

				Thread.Sleep(2000);

				act.MoveToElement(e).Build().Perform();
				act.Click();
				Thread.Sleep(5000);
				e = driver.FindElement(By.LinkText("Job Titles"));
				act.MoveToElement(e).Build().Perform();
				Thread.Sleep(5000);
				e.Click();

				Thread.Sleep(5000);
			}
			catch(Exception ex)
            {

            }
			


		}


	}





	}

