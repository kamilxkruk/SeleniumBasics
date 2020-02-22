using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowcaseTest
{
    class Program
    {
       

        static void Main(string[] args)
        {
            IWebDriver driver = null;


            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();

                new Automations().AutomateJakDojade(driver);

                Console.ReadKey();
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
          

        }
    }

}
