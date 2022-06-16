// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharp_Jakub_Mizera.BaseClass;
using SeleniumCSharp_Jakub_Mizera.Utilities;

namespace SeleniumCSharp_Jakub_Mizera
{
    [TestFixture]
    public class PararellTesting
    {
        IWebDriver driver;
        [Test, Category("UAT Testing"), Category("Module1")]
        public void PararellTesting1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void PararellTesting2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void PararellTesting3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void PararellTesting4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void PararellTesting5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void PararellTesting6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void PararellTesting7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void PararellTesting8()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void PararellTesting9()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void PararellTesting10()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
    }
}
