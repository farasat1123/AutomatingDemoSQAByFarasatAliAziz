using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkScratch.PageObjects
{
    internal class LoginPagecs : PageOperations
    {
        public LoginPagecs(IWebDriver driver) : base(driver)
        { }

        public void PerformLogin(string user, string password)
        {

            EnterText(By.XPath("//input[contains(@name, 'username')]"), user);
            EnterText(By.XPath("//input[contains(@name, 'password')]"), password);
            Click(By.XPath("//button[contains(@class, 'login-button')]"));

        }
    }
}
