using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

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
		public void launchBrowser()
		{

			driver.Navigate().GoToUrl("https://www.orangehrm.com/contact-sales");

		}


		public void countryDropdown()
		{


			IWebElement countries = driver.FindElement(By.Id("input-country"));
			SelectElement se = new SelectElement(countries);
			IList<IWebElement> allCountries = se.Options;

			
			// print size of items in the list
			Console.WriteLine("There are " + allCountries.Count + " listed in the dropdown");

			foreach (IWebElement countriesList in allCountries)
			{
				if (countriesList.Text.Equals("Cuba"))
				{

					countriesList.Click();
					break;
				}
			}

		}

	}

}