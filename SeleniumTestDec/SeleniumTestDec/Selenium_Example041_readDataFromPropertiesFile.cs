using NPOI.Util.Collections;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace com.refer
{

 

	public class Selenium_Example041_readDataFromPropertiesFile
	{
 
		  WebDriver driver;

		[Test]
		public  void Main()
		{

			string path = @"D:\selenium\Selenium\login.properties";
			// This example will give you idea about File handling with properties 
			FileStream fs = null;
			try
			{
				fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
			}
			catch (FileNotFoundException e1)
			{
				// TODO Auto-generated catch block
				Console.WriteLine(e1.ToString());
				Console.Write(e1.StackTrace);
			}




			Properties p = new Properties();
			try
			{
				p.Load(fs);
				Console.WriteLine("hi");
			}
			catch (IOException e)
			{
				// TODO Auto-generated catch block
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}
		 	driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			//driver.Navigate().GoToUrl(p.GetProperty("URL"));
			driver.Navigate().GoToUrl(p["URL"]);
			driver.FindElement(By.Name("txtUsername")).SendKeys(p["Username"]);
			driver.FindElement(By.Name("txtPassword")).SendKeys(p["Password"]);
			driver.FindElement(By.XPath("//*[@id='btnLogin']")).Click();


		}

	}

}