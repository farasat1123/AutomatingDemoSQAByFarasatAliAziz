using FrameworkScratch.DriverBuilder;
using FrameworkScratch.PageObjects;
using NUnit.Framework;


namespace FrameworkScratch.Tests.Login
{
    [TestFixture]
    internal class Login : DriverBuilderClass
    {
        LoginPagecs Page;

        [SetUp]
        public void Setup()
        {
            Page = new LoginPagecs(driver);
        }

        [Test]
        public void VerifyLogin()
        {
            Page.PerformLogin("Admin", "admin123");
            Assert.AreEqual(Page.GetPageURL(), "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index");

        }
    }
}
