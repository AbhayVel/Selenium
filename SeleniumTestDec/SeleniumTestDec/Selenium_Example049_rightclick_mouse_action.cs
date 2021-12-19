using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace com.refer
{
	public class Selenium_Example049_rightclick_mouse_action
	{

		WebDriver driver;

		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();

			driver.Navigate().GoToUrl("http://www.google.com");
			driver.Manage().Window.Maximize();
			 
		}



		[Test]
		public  void mouseaction( )
		{
			IWebElement e = driver.FindElement(By.LinkText("Gmail"));
			Actions act = new Actions(driver);

			act.MoveToElement(e);
			Thread.Sleep(2000);

			act.ContextClick(e).Build().Perform();
			Thread.Sleep(500);
			act.KeyDown(Keys.ArrowDown).Build().Perform();
			act.KeyDown(Keys.ArrowDown).Build().Perform();
			act.Click();
			Thread.Sleep(10000);
			//IWebElement p = driver.FindElement(By.XPath("html/body/ul/li[2]"));
			//p.Click();
		}

	}

}