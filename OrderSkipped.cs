using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesterTalk_Tute.BaseClass;
using TesterTalk_Tute.Utility;

namespace TesterTalk_Tute
{
    public class OrderSkipped
    {
        public IWebDriver driver;
        [Test,Order(1),Category("OrderSkipped")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test,Order(2), Category("OrderSkipped")]
        public void TestMethod2()
        {
            Assert.Ignore("Because of defect");
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test,Order(3), Category("OrderSkipped")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init("firefox");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test, Order(4), Category("OrderSkipped")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init("edge");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }

    }
}
