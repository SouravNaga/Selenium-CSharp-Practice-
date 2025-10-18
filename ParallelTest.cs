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
    public class ParallelTest
    {
        public IWebDriver driver;
        [Test, Category("Element handle"), Category("Module1")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test, Category("Element handle"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test, Category("Element handle"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test, Category("Element handle"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test, Category("Element handle"), Category("Module1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test, Category("Element handle"), Category("Module1")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test, Category("Element handle"), Category("Module1")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test, Category("Element handle"), Category("Module1")]
        public void TestMethod8()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test, Category("Element handle"), Category("Module1")]
        public void TestMethod9()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test, Category("Element handle"), Category("Module1")]
        public void TestMethod10()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
    }
}
