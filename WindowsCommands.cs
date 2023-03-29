using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp_BrowserCommands
{
    internal class WindowsCommands : BrowserCommandsTests
    {
        [Test]
        public void ManageWindows()
        {
            driver.Navigate().GoToUrl(testUrl);

            // Maximize the browser window
            driver.Manage().Window.Maximize();

            // Minimize the browser window
            driver.Manage().Window.Minimize();

            // Modify the window size using the given parameters for width and height
            driver.Manage().Window.Size = new Size(500, 300);
        }
    }
}
