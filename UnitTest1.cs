using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TesterTalk_Tute.BaseClass;
namespace TesterTalk_Tute
{
    public class Tests : BaseTest
    {

        [Test, Category("Smoke Testing")]
        public void Test1()
        {
            
            IWebElement emailText =driver.FindElement(By.XPath(".//*[@id='email']"));
            emailText.SendKeys("Selenium test1");
        }
        [Test, Category("Regression Testing")]
        public void Test2()
        {

            IWebElement emailText = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailText.SendKeys("Selenium test2");
        }
        [Test,Category("Smoke Testing")]
        public void Test3()
        {

            IWebElement emailText = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailText.SendKeys("Selenium test3");
        }
    }
}