using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp_BrowserCommands
{
    internal class BrowserProperties : BrowserCommandsTests
    {
        [Test]
        public void Properties()
        {
            driver.Navigate().GoToUrl(testUrl);

            // Validate that the page title is correct
            Assert.That(driver.Title == "Your Store");

            // Validate that the page Url is correct
            Assert.That(driver.Url == testUrl);

            // Validate that the page source contains expected text
            Assert.That(driver.PageSource.Contains("Top Trending Categories"));
        }
    }
}
