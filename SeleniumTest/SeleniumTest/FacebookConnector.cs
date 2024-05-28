using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;

namespace SeleniumTest
{
    class FacebookConnector
    {
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Initialize()
        {

            //navigate to URL  
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            
            //Maximize the browser window  
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Test]
        public void ExecuteTest()
        {
            //perform browser operations  
            IWebElement ele = driver.FindElement(By.Id("email"));
            ele.SendKeys("abcdef@gmail.com");
            Thread.Sleep(2000);
            Console.WriteLine("username value is entered \n");
            IWebElement ele1 = driver.FindElement(By.Name("pass"));
            ele1.SendKeys("######");
            Console.WriteLine("password is entered");
            IWebElement ele2 = driver.FindElement(By.Id("u_0_5_Ju"));
            ele2.Click();
            Thread.Sleep(3000);
            Console.WriteLine("login button is clicked");
        }
        [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }
    }
}
