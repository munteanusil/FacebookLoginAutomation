using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://www.google.com");

            //IWebElement elementSearch = driver.FindElement(By.Name("q"));
            //Thread.Sleep(3000);
            //elementSearch.SendKeys("buy house in Alicante,Spain");
            //Thread.Sleep(2000);

            //IWebElement elementSearch1 = driver.FindElement(By.Name("btnK"));
            //elementSearch1.Click();

            //Thread.Sleep(3000);
            ////close the browser  
            //driver.Close();
            //Console.Write("test case ended ");

            FacebookConnector test = new FacebookConnector();

            test.Initialize();
            test.ExecuteTest();
            test.EndTest();

        }
    }
}
