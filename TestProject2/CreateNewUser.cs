using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Net.Http;
using System.Web;



namespace CreateNewUser
{
    public class userCreationLambdaTest
    {
        string test_url = "https://google.co.uk";

        IWebDriver driver;
        public WebDriverWait wait;

        // public object Timespan { get; set; }
        // public object HttpContext { get; set; }
        // public object Request { get; set; }

        //public object Current { get; set; }



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

                IWebElement findEmailField = driver.FindElement(By.CssSelector("input[type='email']"));
                driver.Manage()
                          .Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

                findEmailField.SendKeys("reesdaviesiriffiths@hotmail.com");

                driver.Manage()
                          .Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

                IWebElement sendEmail = driver.FindElement(By.CssSelector("button[type='submit']"));

                sendEmail.Click();

                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                IWebElement googleSignIn
                    = wait.Until(driver => driver.FindElement(By.ClassName("googleSignInBtn")));

                string actual_url = this.driver.Url;
                string expected_url = "https://accounts.lambdatest.com/register";

                Assert.That(actual_url, Is.EqualTo(expected_url));
                IWebElement findNameField = driver.FindElement(By.CssSelector("input[type='Text']"));
                findNameField.SendKeys("David Griffiths3");

                IWebElement findPasswordField = driver.FindElement(By.Id("userpassword"));
                findPasswordField.SendKeys("Test12345");

                IWebElement findPhoneNumberField = driver.FindElement(By.CssSelector("input[type='phone']"));
                findPhoneNumberField.SendKeys("07813931277");
                
                IWebElement tickTermsofServiceCheckBox = driver.FindElement(By.CssSelector("input[type='checkbox']"));
                tickTermsofServiceCheckBox.Click();

                IWebElement selectFreeSignUp = driver.FindElement(By.CssSelector("button[type='submit']"));
                selectFreeSignUp.Click();

                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                IWebElement element = wait.Until(driver => driver.FindElement(By.XPath("//a[contains(text(), 'Please Verify your Email')]")));

            }
            else
            //{do the below code or IF NOT visible do the same code}
            {
                IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

                searchText.SendKeys("LambdaTest");
                searchText.SendKeys(Keys.Enter);

                IWebElement website = driver.FindElement(By.CssSelector("h3[class='LC20lb DKV0Md'"));
                website.Click();

                IWebElement findEmailField = driver.FindElement(By.CssSelector("input[type='email']"));
                driver.Manage()
                          .Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

                findEmailField.SendKeys("reesdaviesiriffiths@hotmail.com");

                driver.Manage()
                          .Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

                IWebElement sendEmail = driver.FindElement(By.CssSelector("button[type='submit']"));

                sendEmail.Click();

                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                IWebElement googleSignIn
                    = wait.Until(driver => driver.FindElement(By.ClassName("googleSignInBtn")));

                string actual_url = this.driver.Url;
                string expected_url = "https://accounts.lambdatest.com/register";

                Assert.That(actual_url, Is.EqualTo(expected_url));
                IWebElement findNameField = driver.FindElement(By.CssSelector("input[type='Text']"));
                findNameField.SendKeys("David Griffiths3");

                IWebElement findPasswordField = driver.FindElement(By.Id("userpassword"));
                findPasswordField.SendKeys("Test12345");

                IWebElement findPhoneNumberField = driver.FindElement(By.CssSelector("input[type='phone']"));
                findPhoneNumberField.SendKeys("07813931277");

                IWebElement tickTermsofServiceCheckBox = driver.FindElement(By.CssSelector("input[type='checkbox']"));
                tickTermsofServiceCheckBox.Click();

                IWebElement selectFreeSignUp = driver.FindElement(By.CssSelector("button[type='submit']"));
                selectFreeSignUp.Click();

                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                IWebElement element = wait.Until(driver => driver.FindElement(By.XPath("//a[contains(text(), 'Please Verify your Email')]")));
                ;

            }
        }

    }
}