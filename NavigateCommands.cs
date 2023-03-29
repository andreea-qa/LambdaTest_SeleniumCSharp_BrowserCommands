using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp_BrowserCommands
{
    internal class NavigateCommands : BrowserCommandsTests
    {
        [Test]
        public void NavigateMethods()
        {
            // Navigate to the test URL
            driver.Navigate().GoToUrl(testUrl);

            // Refresh the current page
            driver.Navigate().Refresh();

            // Go back once
            driver.Navigate().Back();

            // Go forward
            driver.Navigate().Forward();
        }
    }
}
