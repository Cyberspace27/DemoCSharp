using DemoCSharp.pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace DemoCSharp.tests
{
    class LoginTest
    {
        private RemoteWebDriver _driver;

        [SetUp]
        public void Initializer()
        {

            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://ingarielvc.online:8080/login?from=%2F");
            Console.WriteLine("Open URL Jenkins ");
            Console.ReadLine();

        }


        [Test]
        public void LoginJenkins()
        {
            LoginPage loginPage = new LoginPage(_driver);
            DashboardPage dashboardPage = loginPage.Login("test1", "test1");
            Assert.IsTrue(dashboardPage.ResponseDashboard());

        }

        [TearDown]
        public void CleanUp()
        {
            _driver.Close();

        }
    }
}
