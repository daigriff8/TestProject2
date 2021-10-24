using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Net.Http;



namespace TestProject2
{
    public class findWebsite
    {
        string test_url = "https://google.co.uk";

        IWebDriver driver;

        public object Timespan { get; private set; }
        public object HttpContext { get; private set; }
        public object Request { get; private set; }

        [SetUp]
        public void start_Browser()
        {
            //local Selenium WebDriver
            driver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application");
            driver.Manage().Window.Maximize();


        }

        [Test]

        public void searchingGoogle()
{
    driver.Url = test_url;

    //System.Threading.Thread.Sleep(2000);

    //if ID is visible
    //{click on the button}

    IWebElement isTAndCsPagePresent = driver.FindElement(By.Id("L2AGLb"));

            driver.Manage()
                  .Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            if (isTAndCsPagePresent != null)
            {
                isTAndCsPagePresent.Click();
                IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

                searchText.SendKeys("LambdaTest");
                searchText.SendKeys(Keys.Enter);

                IWebElement website = driver.FindElement(By.CssSelector("h3[class='LC20lb DKV0Md'"));
                website.Click();

                //string urlForWebsite = Request.Url.Host;

                //Console.WriteLine(urlForWebsite);
            }

            else
            //{do the below code or IF NOT visible do the same code}
            {
                IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

                searchText.SendKeys("LambdaTest");
                searchText.SendKeys(Keys.Enter);

                IWebElement website = driver.FindElement(By.CssSelector("h3[class='LC20lb DKV0Md']"));
                website.Click();

                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("the Test passed");

            }
}

    }
}