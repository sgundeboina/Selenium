namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using Pages;

    public static class Actions
    {
        //routine actions        

        public static IWebDriver driver { get; set; }

        public static ExpectedConditions WaitCondition { get; }

        public static string ApplicationBaseAddress { get; set; }


        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }

    }
}
