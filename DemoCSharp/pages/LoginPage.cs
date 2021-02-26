using DemoCSharp.generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace DemoCSharp.pages
{
    class LoginPage
    {
        private readonly RemoteWebDriver _driver;

        public LoginPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement txtUsername => _driver.FindElementById("j_username");
        public IWebElement txtPassword => _driver.FindElementByName("j_password");
        public IWebElement btnLogin => _driver.FindElementByName("Submit");

        public DashboardPage Login(string username, string pass)
        {

            txtPassword.EnterText(pass);
            txtUsername.EnterText(username);
            btnLogin.ClickElement();
            return new DashboardPage(_driver);

        }

        //  PageFactory.InitElements();

        //public LoginPage()
        //{
        //   PageFactory.InitElements(PropertiesCollection.driver, this);
        //}

        //[FindsBy(How = How.Id, Using = "j_username")]
        //public IWebElement txtUsername { get; set; }

        //[FindsBy(How = How.Name, Using = "j_password")]
        //public IWebElement txtPassword { get; set; }

        //[FindsBy(How = How.Name, Using = "Submit")]
        //public IWebElement btnLogin { get; set; }


    }
}
