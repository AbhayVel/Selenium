using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace com.refer
{

	public class Selenium_Example014_Dropdown_Approach1
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

			driver.Navigate().GoToUrl("https://www.orangehrm.com/contact-sales/");
			Thread.Sleep(2000);
			countryDropdown();
		}


		public void countryDropdown()
		{
            try
            {

            
			IWebElement countries = driver.FindElement(By.Id("Form_submitForm_Country"));
			SelectElement se = new SelectElement(countries);
			se.SelectByText("Greece");
			se.SelectByValue("India");
			se.SelectByIndex(101);
			IList<IWebElement> allCountries = se.Options;
		
			// print size of items in the list
			Console.WriteLine("There are " + allCountries.Count + " listed in the dropdown");
			Console.WriteLine("Countries list are:");
			foreach (IWebElement countriesList in allCountries)
			{
				Console.WriteLine(countriesList.Text);
			}
			}
			catch(Exception ex)
            {

            }
		}

	}

}