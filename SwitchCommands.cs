using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp_BrowserCommands
{
    internal class SwitchCommands : BrowserCommandsTests
    {
        [Test]
        public void SwitchWindows()
        {
            // Get the current window’s handle
            var handle = driver.CurrentWindowHandle;

            // Get the list of all opened windows’ handles
            var handles = driver.WindowHandles; 

            //Switch to the window you want active in your test
            driver.SwitchTo().Window(handle);

            //Switch to the window you want active in your test, by selecting it from a list
            driver.SwitchTo().Window(handles[3]);
        }

        [Test]
        public void DismissAlert()
        {
            // Navigate to the desired page
            driver.Navigate().GoToUrl("https://www.lambdatest.com/selenium-playground/javascript-alert-box-demo");

            // Identify the button to click
            driver.FindElement(By.XPath("//div[contains(text(),'Java Script Alert Box')]/following-sibling::p/button")).Click();

            // Dismiss the alert
            driver.SwitchTo().Alert().Dismiss();
        }

        [Test]
        public void SendKeysAndAcceptAlert()
        {
            // Navigate to the desired page
            driver.Navigate().GoToUrl("https://www.lambdatest.com/selenium-playground/javascript-alert-box-demo");

            // Identify the button to click
            driver.FindElement(By.XPath("//div[contains(text(),'Java Script Alert Box')]/following-sibling::p/button")).Click();

            // Enter text in the alert box
            driver.SwitchTo().Alert().SendKeys("It's me, Mario"); 

            // Accept the alert
            driver.SwitchTo().Alert().Accept();
        }
    }
}
