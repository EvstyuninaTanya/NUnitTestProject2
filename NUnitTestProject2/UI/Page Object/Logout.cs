using HW21.Business_object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW21
{
    class Logout
    {
        private IWebDriver driver;
        public Logout(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnNorthWind2(Headers nw)
        {
            new Actions(driver).Click(driver.FindElement(By.XPath($"(//a[contains(text(), \"{nw.HeaderLogout}\")])"))).Build().Perform();
        }
    }
}

