using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace com.refer
{
	public class Selenium_Example014_Dropdown_Approach3
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

			driver.Navigate().GoToUrl("https://www.orangehrm.com/contact-sales/");

		}

		[Test]
		public void countryDropdown()
		{
			SelectElement noOfEmployees = new SelectElement(driver.FindElement(By.Name("NoOfEmployees")));
			
			  noOfEmployees.SelectByText("401 - 450");

			SelectElement noOfCountries = new SelectElement(driver.FindElement(By.Name("Country")));
			noOfCountries.SelectByText("Austria");
		}

	}

}