using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace com.refer
{

    public class Selenium_Example010_implicitwait
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

			driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);
			e.Clear();

			Assert.AreEqual("", e.Text, "User Name should be empty.");
		}

	}





}