using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace com.refer
{

		public class Selenium_Example020_DateFormat
		{


		[Test]
		public  void datepickup()
		{
			// Date Picker

			 
			 //get current date time with Date()
			 string TodayDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

			 // Now format the date
			 
			 // Print the Date
			 Console.WriteLine(TodayDate);
		}
		}












}