using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace com.refer
{


	public class Selenium_Example025_managecookies
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
			driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");

		}

		public void Setcookies()
		{
			driver.Manage().Cookies.AddCookie(new Cookie("Name", "Amruta"));
			driver.Manage().Cookies.AddCookie(new Cookie("test1", "cookie1"));
			driver.Manage().Cookies.AddCookie(new Cookie("test2", "cookie2"));
			var cookie = driver.Manage().Cookies.GetCookieNamed("foo");

			// Get All available cookies
			var cookies = driver.Manage().Cookies.AllCookies;
			// delete a cookie with name 'test1'	
			driver.Manage().Cookies.DeleteCookieNamed("test1");


		}
	}

	}

