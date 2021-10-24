using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace TestProject2
{
    public class createAccount

    {
        IWebDriver driver;

        //TestProject2.findWebsite findWebsiteDriver = new TestProject2.findWebsite();
        //string findWebsiteDriver = findWebsite.;

        //            You've just got it backwards. You want to instantiate the class that has the method you want to call:

        //welcome.WelcomeSpeech mySpeech = new welcome.WelcomeSpeech();
        //        string mySpeechText = mySpeech.speech();

        //        Also, use "[" code "]" and "[" /code "]" (with the square brackets, but without the quotes or the spaces) for code blocks.

        //        Happy programming!

    };

    [Test]
    public void sendEmail()
    {
        IWebElement findEmailField = driver.FindElement(By.CssSelector("input[type='email']"));
        driver.Manage()
                  .Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

        findEmailField.SendKeys("reesdaviesgriffiths@hotmail.com");

        driver.Manage()
                  .Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

        IWebElement sendEmail = driver.FindElement(By.CssSelector("button[type='submit']"));

    }

    [TearDown]

    public void close_Browser()
    {
        driver.Quit();
    }
}