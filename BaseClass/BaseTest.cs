using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterTalk_Tute.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;
        [SetUp]
        public void open()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
        }
        [TearDown]
        public void close()
        {
            driver.Quit();
        }
    }
}
