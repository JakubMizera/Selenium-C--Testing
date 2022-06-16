using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp_Jakub_Mizera.BaseClass
{
    public class ListTest
    {
        public IWebDriver driver2;

        [SetUp]
        public void Open()
        {
            driver2 = new ChromeDriver();
            driver2.Manage().Window.Maximize();
            driver2.Url = "https://www.facebook.com/r.php?r=101";
        }

        [TearDown]
        public void Close()
        {
            driver2.Quit();
        }

    }
}
