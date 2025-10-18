using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesterTalk_Tute.BaseClass;
using TesterTalk_Tute.Utility;
using NUnit.Framework;
using System.Collections;

namespace TesterTalk_Tute
{
    public class AuthorDescription_DataProvider
    {
        public void HighlightElement(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].style.border='3px solid red'", element);
        }
        [Test]
        [Author("Sourav","souravnaga@gmail.com")]
        [Description("Sample Description")]
        public void Auth1()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test]
        [Author("Sourav", "souravnaga@gmail.com")]
        [Description("Sample Description")]
        public void Auth2()
        {
            var Driver = new BrowserUtility().Init("chrome");
            IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
            textbox.SendKeys("Testing purpose");
            Thread.Sleep(1000);
            Driver.Close();
        }
        [Test]
        [Author("Sourav", "souravnaga@gmail.com")]
        [Description("Sample Description")]
        [TestCaseSource("getData")]
        public void Auth3(string browser)
        {
            IWebDriver Driver = null;
            try
            {
                Driver = new BrowserUtility().Init(browser);
                IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
                textbox.SendKeys("Testing purpose");
                Thread.Sleep(1000);
                Driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if(Driver!=null)
                {
                    Driver.Quit();
                }
            }
        }
        [Test]
        [Author("Sourav", "souravnaga@gmail.com")]
        [Description("Sample Description")]
        public void Auth4()
        {
            IWebDriver Driver = null;
            try
            {
                Driver = new BrowserUtility().Init("chrome");
                IWebElement textbox = Driver.FindElement(By.XPath("//input[@id='textInputField']"));
                try
                {
                    HighlightElement(Driver, textbox);
                }
                catch (Exception ex) {
                    Console.WriteLine("Element not found");
                    Console.WriteLine(ex.StackTrace);
                }
                textbox.SendKeys("Testing purpose");
                Thread.Sleep(1000);
                Driver.Quit();
            }
            catch (Exception ex)
            {
                Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
                string filePath = Path.Combine("C:\\Users\\soura\\source\\repos\\TesterTalk_Tute\\Screenshots\\", "screenshot.png");
                ss.SaveAsFile(filePath); // No enum needed
                Console.WriteLine("Screenshot saved at: " + filePath);


                Console.WriteLine(ex.StackTrace);
                throw;
            }
            finally
            {
                if (Driver != null)
                {
                    Driver.Quit();
                }
            }
        }

        static IList getData()
        {
            ArrayList list = new ArrayList();
            list.Add("chrome");
            list.Add("firefox");
            list.Add("edge");
            return list;
        }
        
    }
}
