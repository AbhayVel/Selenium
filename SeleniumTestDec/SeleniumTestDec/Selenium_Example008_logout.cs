using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace com.refer
{


	public class Selenium_Example008_logout
	{
		WebDriver driver;

		[OneTimeSetUp]
		public void Setup() {
			driver = new ChromeDriver();
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
		public  void login()
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
		public  void logout()
		{
			IWebElement e = driver.FindElement(By.XPath("//*[@id='welcome']"));
			e.Click();

			e = driver.FindElement(By.XPath("//*[@id='welcome-menu']/ul/li[3]/a"));
			e.Click();
		}
	}

}