using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace com.refer
{

 

	public class Selenium_Example015_DropDown_MuliSelect
	{

		WebDriver driver;
		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("http://output.jsbin.com/osebed/2");
		}

		[Test]
		public void Main()
		{

			 
			dropdown();

		}


		public  void dropdown()
		{
			
			 
			IWebElement e = driver.FindElement(By.XPath("//*[@id='fruits']"));
			SelectElement selec = new SelectElement(e);
			 
			selec.SelectByText("Apple");
			Thread.Sleep(1000);
			selec.SelectByIndex(2);
			Thread.Sleep(1000);
			selec.DeselectByIndex(1);
			IList<IWebElement> options = selec.AllSelectedOptions;
			for (int i = 0; i < options.Count; i++)
			{
				Console.WriteLine("text is :" + options[i].Text);
				Console.WriteLine("value is :" + options[i].GetAttribute("value"));
			}
			Thread.Sleep(8000);
		}

	}

}