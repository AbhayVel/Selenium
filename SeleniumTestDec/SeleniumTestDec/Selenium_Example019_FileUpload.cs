using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace com.refer
{


	 
	public class Selenium_Example019_FileUpload
	{
	  WebDriver driver;


		[Test]
			public void Main()
			{


				login();
				try
				{
					Thread.Sleep(5000);
				}
				catch (Exception e)
				{

					Console.WriteLine(e.ToString());
					Console.Write(e.StackTrace);
				}
				fileUpload();

			}



			public   void login()
			{
			 	driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/pim/addEmployee");
			driver.Manage().Window.Maximize();
			IWebElement e = driver.FindElement(By.Id("txtUsername"));
				e.SendKeys("Admin");
				e = driver.FindElement(By.Id("txtPassword"));
				e.SendKeys("admin123");
				e = driver.FindElement(By.Name("Submit"));
				e.Click();


			}
			public  void fileUpload()
			{
				IWebElement obj = driver.FindElement(By.XPath("//input[@id='photofile']"));
				obj.SendKeys("D:\\Amruta\\AmrutaSelenium_Examples\\TextFile.txt");
			}







	}


}