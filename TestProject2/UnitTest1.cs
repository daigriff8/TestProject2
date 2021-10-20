using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject2
{
    public class SearchingGoogle
    {
        string test_url = "https://google.co.uk";

        IWebDriver driver;        
        
        [SetUp]
        public void start_Browser()
        {
            //local Selenium WebDriver
            driver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application");
            driver.Manage().Window.Maximize();


        }

        [Test]
        public void test_search()
        {
            driver.Url = test_url;

            System.Threading.Thread.Sleep(2000);

            //if ID is visible
            //{click on the button}

            if (IWebElement isTAndCsPagePresent = driver.FindElement(By.Id("L2AGLb"));

            { isTAndCsPagePresent.Click; }

            else if
            //{do the below code or IF NOT visible do the same code}
            { IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

                searchText.SendKeys("LambdaTest");
                searchText.SendKeys(Keys.Enter);

                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("the Test passed");

            }
            else
            {
                IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

                searchText.SendKeys("LambdaTest");
                searchText.SendKeys(Keys.Enter);

                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("the Test passed");
            }

        [TearDown]

        public void close_Browser()
        {
            driver.Quit();
        }
    }
}