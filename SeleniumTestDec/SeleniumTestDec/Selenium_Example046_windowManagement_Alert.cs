using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace com.refer
{


	public class Selenium_Example046_windowManagement_Alert
	{
		WebDriver driver;

		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();

			driver.Navigate().GoToUrl("https://mail.rediff.com/cgi-bin/login.cgi");
			driver.Manage().Window.Maximize();
		}
		[Test]
		
		public  void startAlert()
		{
		
			
			driver.FindElement(By.Name("proceed")).Click();
			
			IAlert al = driver.SwitchTo().Alert();
			Console.WriteLine(al.Text);
			al.Accept(); // ok
			// al.dismiss();// cancel
			driver.SwitchTo().DefaultContent();
		}

	}
}