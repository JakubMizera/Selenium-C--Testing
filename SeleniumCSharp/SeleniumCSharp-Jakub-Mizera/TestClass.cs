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

namespace SeleniumCSharp_Jakub_Mizera
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Regression Testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }
    }
    [TestFixture]
    public class TestClassList : ListTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethodList()
        {
            IWebElement monthDropdownList = driver2.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);//Select by index = Jan
            //element.SelectByText("Mar");//Select by text = Mar
            element.SelectByValue("6");//Select by value = Jun
        }
    }
}
