using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesterTalk_Tute.BaseClass;

namespace TesterTalk_Tute
{
    public class ElementsHandle : BaseTest
    {
        [Test,Category("Element handle")]
        public void HandleDropDOwn()
        {
            Console.WriteLine("Drop down handle");
            IWebElement dropdown = driver.FindElement(By.XPath("//select[@id='dropdownField']"));
            SelectElement select = new SelectElement(dropdown);
            select.SelectByIndex(2);
            Thread.Sleep(1000);
            select.SelectByValue("Tesla");
            Thread.Sleep(1000);
            select.SelectByText("BMW");
            Thread.Sleep(1000);
        }
    }
}
