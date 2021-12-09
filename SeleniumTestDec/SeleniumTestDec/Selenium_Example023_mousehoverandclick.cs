namespace com.refer
{
 
	  using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;

    public class Selenium_Example023_mousehoverandclick
	{

		WebDriver driver;
		[SetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/pim/addEmployee");

		}

		[Test]
		public void Test1()
		{
			IWebElement element = driver.FindElement(By.XPath("//*[@id='menu_pim_viewPimModule']"));
			IWebElement tohover = driver.FindElement(By.XPath("//*[@id='menu_pim_Configuration']"));
			IWebElement toclick = driver.FindElement(By.XPath("//*[@id='menu_pim_configurePim']"));
			hover(driver, element);
			hoverandclick(driver, tohover, toclick);

		}



		public   void login()
		{
			IWebElement e = driver.FindElement(By.Id("txtUsername"));
			e.SendKeys("Admin");
			e = driver.FindElement(By.Id("txtPassword"));
			e.SendKeys("admin123");
			e = driver.FindElement(By.Name("Submit"));
			e.Click();


		}

		public  void hover(WebDriver driver, IWebElement element)
		{
			Actions action = new Actions(driver);
			action.MoveToElement(element);

		}
		public static void hoverandclick(WebDriver driver, IWebElement tohover, IWebElement toclick)
		{
			Actions action = new Actions(driver);
			action.MoveToElement(tohover).Click(toclick).Build().Perform();
		}

	}






}