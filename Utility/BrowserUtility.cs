using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;

namespace TesterTalk_Tute.Utility
{
    public class BrowserUtility
    {
        public IWebDriver Init(string browser)
        {
            IWebDriver driver;

            switch (browser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;

                case "firefox":
                    driver = new FirefoxDriver();
                    break;

                case "edge":
                    driver = new EdgeDriver();
                    break;

                default:
                    driver = new ChromeDriver(); // fallback
                    break;
            }

            driver.Manage().Window.Maximize();
            driver.Url = "https://dd-demo-tau.vercel.app/web_elements.html";
            return driver;
        }
    }
}