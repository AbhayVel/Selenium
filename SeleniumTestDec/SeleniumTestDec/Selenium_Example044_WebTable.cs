using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace com.refer
{


	public class Selenium_Example044_WebTable
	{

		WebDriver driver;

		[OneTimeSetUp]
		public void Setup()
		{
			driver = new ChromeDriver();

			driver.Navigate().GoToUrl("https://money.rediff.com/gainers/bse/daily/groupa?src=gain_lose");
			driver.Manage().Window.Maximize();
		}
		[Test]
		
				  public  void listcompanies()
				  {
					  string company = "Prism Johnson";

						

						  IList<IWebElement> names = (IList<IWebElement>)driver.FindElements(By.XPath("//table[@class='dataTable']/tbody/tr/td[1]"));
						  IList<IWebElement> prices = (IList<IWebElement>)driver.FindElements(By.XPath("//table[@class='dataTable']/tbody/tr/td[4]"));
						  Console.WriteLine("Total companies " + names.Count);
						  Console.WriteLine("Total prices " + prices.Count);

						  for (int i = 0;i < names.Count;i++)
						  {
							  if (company.Equals(names[i].Text))
							  {
								  Console.WriteLine(names[i].Text + " -- " + prices[i].Text);
								  break;
							  }

						  }
				  }



	}



}