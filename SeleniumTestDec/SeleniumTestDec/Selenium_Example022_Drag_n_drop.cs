using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

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
			driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Dragging.html");

		}

		[Test]
		public void Dragndrop()
		{
			IWebElement e = driver.FindElement(By.Id("item5"));
			IWebElement e1 = driver.FindElement(By.Id("item1"));
			Actions action = new Actions(driver);
			action.DragAndDrop(e, e1).Build().Perform();
		}

	}
}

