
namespace AutoFramework
{
    using AutoFramework.Pages;
    using NUnit.Framework;



    public class LoginPageScenarios
    {
        
        public LoginPageScenarios()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();

        }

        [Test]
        public void LessThan5Chars()
        {
            var LoginPageObj = new LoginPage();
            var resStr = LoginPageObj.FillLoginForm(Config.Credentials.Valid.Username,
                                                   Config.Credentials.Invalid.Password.FourCharacters,
                                                   Config.Credentials.Invalid.Password.FourCharacters);


            Assert.AreEqual(Config.AlertsTexts.PasswordLenghtOutOfRange, resStr);

        }

        [Test]
        public void MoreThan12Chars()
        {
            Assert.AreEqual("Test", "Test");

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Actions.CloseDriver();
        }
    }
}