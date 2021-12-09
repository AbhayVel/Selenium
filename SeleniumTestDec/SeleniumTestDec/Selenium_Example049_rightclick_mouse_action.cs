using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

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
			driver.SwitchTo().Frame(0);
		}



		[Test]
		public  void mouseaction( )
		{
			IWebElement e = driver.FindElement(By.XPath("html/body/div[1]/section/div/div/div/p/span"));
			Actions act = new Actions(driver);
			act.ContextClick(e).Build().Perform();
			IWebElement p = driver.FindElement(By.XPath("html/body/ul/li[2]"));
			p.Click();
		}

	}

}