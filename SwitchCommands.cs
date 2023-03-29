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
            driver.Navigate().GoToUrl("https://www.lambdatest.com/selenium-playground/javascript-alert-box-demo");

;        }
    }
}
