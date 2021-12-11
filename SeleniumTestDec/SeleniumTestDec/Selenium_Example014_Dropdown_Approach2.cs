using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace com.refer
{


	public class Selenium_Example014_Dropdown_Approach2
	{
		WebDriver driver;

		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
		}


		[Test]
		[Order(1)]
		public void launchBrowser()
		{

			driver.Navigate().GoToUrl("https://www.orangehrm.com/contact-sales");

		}

		[Test]
		[Order(2)]
		public void countryDropdown()
		{


			IWebElement countries = driver.FindElement(By.Id("Form_submitForm_Country"));
			SelectElement se = new SelectElement(countries);
			IList<IWebElement> allCountries = se.Options;

			
			// print size of items in the list
			Console.WriteLine("There are " + allCountries.Count + " listed in the dropdown");

			foreach (IWebElement countriesList in allCountries)
			{
				if (countriesList.Text.Contains("Ca"))
				{

					countriesList.Click();
					break;
				}
			}

			Thread.Sleep(8000);

		}

	}

}