using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace com.refer
{

	public class Selenium_Example011_Radiosingleselection
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
			driver.Navigate().GoToUrl("https://www.quickitdotnet.co.in/practice-project");

		}

		[Test]
		public  void radio()
	{
			// As we can see, all the radio buttons are being created using the HTML tag <input> and have an attribute named "type", 
		//which has a value "radio", which signifies that the type of the input element is a radio button.

		 //Now, let's see how we can locate and perform specific actions on the Radion Buttons using Selenium WebDriver?
		  IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
		  js.ExecuteScript("window.scrollBy(0,1000)");
		IWebElement radioElement = driver.FindElement(By.Id("radio2"));
			Thread.Sleep(5000);

			radioElement.Click();

			Thread.Sleep(5000);
	}
	}

}