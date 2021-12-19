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

			WebDriver driver;

			[OneTimeSetUp]
			public void Setup()
			{
				driver = new ChromeDriver();
				driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("http://jqueryui.com/slider/");
		}


			
		[Test]
			public void sliderTest()
			{
		IWebElement frame1 =	driver.FindElement(By.ClassName("demo-frame"));
				driver.SwitchTo().Frame(frame1);
			Thread.Sleep(3000);
			IWebElement slider = driver.FindElement(By.Id("slider"));




			Actions move = new Actions(driver);

            move.DragAndDropToOffset(slider, 10,60).Build().Perform(); ;
            //move.ClickAndHold(slider);
            //move.MoveByOffset(10, 60);
            //move.Release(slider).Build().Perform();
            Thread.Sleep(6000);

			}
		}
	 



}