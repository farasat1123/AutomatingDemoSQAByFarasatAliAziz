using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


class FormAutomation
{
    static void Main(string[] args)
    {
        // Initialize the ChromeDriver
        using (var driver = new ChromeDriver(@"C:\Users\Farasat Aziz\AppData\Local\Programs\Python\Python310\Scripts\chromedriver.exe"))
        {
            // Navigate to the webpage
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();


            // Find the form elements using their ID
            var firstNameField = driver.FindElement(By.Id("firstName"));
            var lastNameField = driver.FindElement(By.Id("lastName"));
            var emailField = driver.FindElement(By.Id("userEmail"));
            var genderField = driver.FindElement(By.Id("gender-radio-2"));
            var submitButton = driver.FindElement(By.Id("submit"));

            // Fill out the form
            firstNameField.SendKeys("John");
            lastNameField.SendKeys("Smith");
            emailField.SendKeys("john.smith@example.com");
            System.Threading.Thread.Sleep(5000); // 5 seconds
            genderField.Click();


            // Scroll to the submit button
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", submitButton);


            // Submit the form
            submitButton.Click();
        }
    }
}
