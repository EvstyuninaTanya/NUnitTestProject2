using HW21.Business_object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW21
{
    class AllProducts
    {
        private IWebDriver driver;
        public AllProducts(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement searchButton => driver.FindElement(By.CssSelector(".btn"));
        public GotoMyProduct ClickOnNorthWind(Headers nw)
        {
            new Actions(driver).Click(driver.FindElement(By.XPath($"(//a[contains(text(), \"{nw.allproducts}\")])[2]"))).Build().Perform();
            return new GotoMyProduct(driver);
        }
        public AddAndViewProduct ClickOnCreate()
        {
            new Actions(driver).Click(searchButton).Build().Perform();
            return new AddAndViewProduct(driver);
        }
    }
}

