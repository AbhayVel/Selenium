using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace com.refer
{

	public class Selenium_Example014_Dropdown_Approach4
	{
		WebDriver driver;
		By country = By.Name("Country");
		By employees = By.Name("NoOfEmployees");
		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			
		}


		[Test]
		public void launchBrowser()
		{
			driver.Navigate().GoToUrl("https://www.orangehrm.com/contact-sales/");

            By employees = null;
            selectOptionFromDropdown(employees, DropDown.Index.ToString(),"2");
			selectOptionFromDropdown(employees, DropDown.Text.ToString(),"51 - 75");
			selectOptionFromDropdown(country, DropDown.Value.ToString(),"Bahrain");

		}



		[Test]
		public static void selectOptionFromDropdown(By locator, string type, string value)
		{

			SelectElement se = new SelectElement((IWebElement)locator);


			switch (type)
			{
				case "Index":
					se.SelectByIndex(int.Parse(value));

					break;

				case "Value":
					se.SelectByValue(value);

					break;
				case "VisibleText":

					se.SelectByText(value);

					break;
				default:
					Console.WriteLine("Please pass correct selection criteria");
					break;
			}


		}

	//	[Test]
		public  IWebElement GetElement(By locator)
		{

			return driver.FindElement(locator);
		}
	
	}



}