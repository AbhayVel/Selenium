using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace com.refer
{


	public class Selenium_Example053_Slider
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
				driver.Navigate().GoToUrl("http://jqueryui.com/slider/");

			}
			public void slider1()
			{
				driver.SwitchTo().Frame(0);
				IWebElement slider = driver.FindElement(By.XPath("//*[@id='slider']/span"));



				//Using Action Class


				Actions move = new Actions(driver);

				move.DragAndDropToOffset(slider, 10, 300).Build().Perform();



			}
		}
	}



}