using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace com.refer
{

	public class Selenium_Example022_Drag_n_drop
	{
		WebDriver driver;


		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("https://www.w3schools.com/html/html5_draganddrop.asp");

		}

		[Test]
		public void Dragndrop()
		{
			IWebElement e = driver.FindElement(By.Id("drag1"));
			IWebElement e1 = driver.FindElement(By.Id("div2"));
			Actions action = new Actions(driver);
			action.DragAndDrop(e, e1).Build().Perform();
			Thread.Sleep(19000);

		}

	}
}

