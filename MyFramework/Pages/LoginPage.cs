namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class LoginPage
    {
        IWebDriver _driver;
        public LoginPage()
        {
            _driver = Actions.driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Name, Using = "userid")]
        public IWebElement UsernameField { get; set; }

        [FindsBy(How = How.Name, Using = "passid")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Name, Using = "repeatpassid")]
        public IWebElement RepeatPasswordField { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement LoginButton { get; set; }

        
        public string FillLoginForm(string username, string password, string repeatPassword)
        {
            UsernameField.Clear();
            UsernameField.SendKeys(username);
            PasswordField.Clear();
            PasswordField.SendKeys(password);
            RepeatPasswordField.Clear();
            RepeatPasswordField.SendKeys(repeatPassword);
            LoginButton.Click();

            var appAlert = _driver.SwitchTo().Alert();

            var tempstr = appAlert.Text;
            appAlert.Accept();
            return tempstr;


        }
    }


   
}
