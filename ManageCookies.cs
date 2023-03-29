using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp_BrowserCommands
{
    internal class ManageCookies : BrowserCommandsTests
    {
        [Test]
        public void CookiesCommands()
        {
            driver.Navigate().GoToUrl(testUrl);

            // Add a new cookie
            driver.Manage().Cookies.AddCookie(new Cookie("cookieName", "value"));

            // Retrieve a cookie based on its name
            // In this case, the "curency" cookie
            var cookie = driver.Manage().Cookies.GetCookieNamed("currency");

            // Delete a cookie based on its name
            // In this case, the "language" cookie
            driver.Manage().Cookies.DeleteCookieNamed("language");

            // Delete a given cookie
            // In this case, the cookie saved as a variable earlier
            driver.Manage().Cookies.DeleteCookie(cookie);

            // Deletes all the cookies
            driver.Manage().Cookies.DeleteAllCookies(); 
        }
    }
}
