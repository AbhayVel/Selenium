using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace com.refer
{
	
	public class Selenium_Example052_KeyboardEventusingshift
	{
		public class login
		{

			WebDriver driver;

			[OneTimeSetUp]
			public void Setup()
			{
				driver = new ChromeDriver();
				driver.Manage().Window.Maximize();
			}


			[Test]
			public void launchBrowser()
			{
				driver.Navigate().GoToUrl("http://www.google.com");

			}
			public void mousemove()
            {

				IWebElement e = driver.FindElement(By.LinkText("Gmail"));
				Actions act = new Actions(driver);
				act.MoveToElement(e);
				act.KeyDown(Keys.Shift).Click(e).KeyUp(OpenQA.Selenium.Keys.Shift).Build().Perform();


			}




		}

	}

}