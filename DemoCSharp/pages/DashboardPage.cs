using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace DemoCSharp.pages
{
    class DashboardPage
    {
        private readonly RemoteWebDriver _driver;

        public DashboardPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement lblJenkinsNameIcon => _driver.FindElementById("jenkins-name-icon");

        public bool ResponseDashboard()
        {
            Console.WriteLine("Dashboard methods are availables");
            return true;
        }


        //public DashboardPage()
        //{
        //    PageFactory.InitElements(PropertiesCollection.driver, this);
        //}

        //[FindsBy(How = How.Id, Using = "jenkins-name-icon")]
        //public IWebElement lblJenkinsNameIcon { get; set; }

        //public bool ResponseDashboard()
        //{
        //    Console.WriteLine("Dashboard methods are availables");
        //    return true;
        //}

    }
}
