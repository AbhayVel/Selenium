using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace com.refer
{

	public class Selenium_Example021_TakingScreenshot
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
			driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/pim/addEmployee");
			login();
			GrabScreenShot();
		}



		public void login()
			{
				
				IWebElement e = driver.FindElement(By.Id("txtUsername"));
				e.SendKeys("Admin");
				e = driver.FindElement(By.Id("txtPassword"));
				e.SendKeys("admin123");
				e = driver.FindElement(By.Name("Submit"));
				e.Click();


			}


			public  void GrabScreenShot()
			{
			ITakesScreenshot screenshot = driver as ITakesScreenshot;
			Screenshot screenshot1 = screenshot.GetScreenshot();
			screenshot1.SaveAsFile(@"D:\Amruta.png", ScreenshotImageFormat.Png);
			screenshot1.SaveAsFile(@"D:\Amruta.jpeg", ScreenshotImageFormat.Jpeg);
			



			}





	}


}