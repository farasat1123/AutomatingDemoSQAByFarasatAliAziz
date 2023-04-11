using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkScratch.DriverBuilder
{
    [TestFixture]
    internal class DriverBuilderClass
    {
        internal IWebDriver driver;

        [SetUp]
        public void BeforeEach()
        {
            CreateDriver();
            OpenURL();
        }
        public void CreateDriver()
        {
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
            }
            catch (Exception ex)
            {
            }
        }
        public void OpenURL()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }
    }
}
