using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowcaseTest
{
    public class Automations
    {
        #region Const Xpaths
        private const string googleInputXpath = @"//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input";
        private const string googleSearchButtonXpath = @"//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[1]";

        private const string goToCitySearchButtonXpath = @"//*[@id='container']/starting-screen/div/div/div[2]/div[2]/ng-transclude/desktop-starting-screen/div/button";
        
        #endregion

        public void AutomateJakDojade(IWebDriver webDriver)
        {
            webDriver.Navigate().GoToUrl(@"https:\\jakdojade.pl\lista-miast");

            var goToCitySearchButton = webDriver.FindElements(By.XPath(goToCitySearchButtonXpath)).FirstOrDefault();
            goToCitySearchButton.Click();

            var cities = webDriver.FindElements(By.XPath(@"//*[@id='citiesContainer']/li"));
            var cityNames = cities.Select(c => c.Text);
            var katowice = cities.Where(c => c.Text.Contains("Katowice")).FirstOrDefault();
            katowice.Click();
        }

        public void AutomateGoogle(IWebDriver webDriver, string searchPhrase)
        {
            webDriver.Navigate().GoToUrl("https:\\google.com");
            var googleInput = webDriver.FindElements(By.XPath(googleInputXpath)).FirstOrDefault();
            var googleSearchButton = webDriver.FindElements(By.XPath(googleSearchButtonXpath)).FirstOrDefault();

            googleInput.SendKeys("Selenium" + Keys.Escape + Keys.Enter);
        }
    }
}
