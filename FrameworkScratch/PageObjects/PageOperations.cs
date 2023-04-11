using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkScratch.PageObjects
{
    internal class PageOperations
    {
        ///<summary>
        ///Enter Text in Element By
        ///</summary>
        protected IWebDriver driver;

        internal PageOperations(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void EnterText(By element, string value) 
        {
            try
            {
                var Inputelement = driver.FindElement(element);
                Inputelement.Click();
                Inputelement.SendKeys(value);
            }

            catch (Exception ex) { 
                
            }
            
        }

        internal void Click(By element) { 
            driver.FindElement(element).Click();
        }

        internal string GetPageURL() {
            return driver.Url;
        }


        internal void printMap() { 
        

        }
    }
}
