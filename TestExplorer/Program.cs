using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExplorer
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {  
        }
        [SetUp]
        public void Initialize()
        {
           
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Opened URL");
        }
         [Test]
        public void ExecuteTest()
        {           
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("execute");
            Console.WriteLine("Executed test");
        }
        [Test]
        public void NextStep()
        {
            Console.WriteLine("Next method..");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Close the browser");
        }
    }
}
