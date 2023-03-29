using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SeleniumCSharp_BrowserCommands
{
    public class BrowserCommandsTests
    {
        protected static IWebDriver driver;
        private static readonly string gridURL = "@hub.lambdatest.com/wd/hub";
        private static readonly string LT_USERNAME = Environment.GetEnvironmentVariable("LT_USERNAME");
        private static readonly string LT_ACCESS_KEY = Environment.GetEnvironmentVariable("LT_ACCESS_KEY");
        protected static readonly string testUrl = "https://ecommerce-playground.lambdatest.io/";

        [SetUp]
        public void Setup()
        {
            ChromeOptions capabilities = new ChromeOptions();
            capabilities.BrowserVersion = "108.0";
            Dictionary<string, object> ltOptions = new Dictionary<string, object>();
            ltOptions.Add("username", LT_USERNAME);
            ltOptions.Add("accessKey", LT_ACCESS_KEY);
            ltOptions.Add("platformName", "Windows 11");
            ltOptions.Add("project", "Selenium Scroll");
            ltOptions.Add("w3c", true);
            ltOptions.Add("plugin", "c#-nunit");
            capabilities.AddAdditionalOption("LT:Options", ltOptions);
            driver = new RemoteWebDriver(new Uri($"https://{LT_USERNAME}:{LT_ACCESS_KEY}{gridURL}"), capabilities);
        }

        [Test]
        public void NavigateMethods()
        {
            driver.Navigate().GoToUrl(testUrl);
            driver.Navigate().Refresh();
            driver.Navigate().Back();
            driver.Navigate().Forward();
        }

        [Test]
        public void NavigateTest()
        {     
            driver.Navigate().GoToUrl(testUrl);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.PartialLinkText("Special")).Click();
            Assert.That(driver.Title.Equals("Special Offers"));
            driver.Navigate().Back();
            Assert.That(driver.Url.Equals(testUrl));
            var cookie = driver.Manage().Cookies.GetCookieNamed("currency");
            Assert.That(cookie.Value.Equals("USD"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}