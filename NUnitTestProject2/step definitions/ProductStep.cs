using HW21.Business_object;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace HW21.step_definitions
{
    [Binding]
    class ProductStep
    {
        private IWebDriver driver;
        [Given(@"Given I open ""(.*)"" url")]
        public void GivenIOpenUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;
        }

        [When(@"I click on button ""(.*)""")]
        public void WhenIClickOnButton(string button)
        {
            new AllProducts(driver).ClickOnNorthWind(new Headers(button, null, null, null));
        }
        [When(@"I select product""(.*)""")]
        public void ISelectProduct(string product)
        {
            new GotoMyProduct(driver).ClickOnNorthWind3(new Product(product, null, null, null, null, null, null, null, null, null, null));
        }
        [Then(@"Product name should be ""(.*)""")]
        public void ThenProductNameShouldBe(string exeptedName)
        {
            Assert.AreEqual(exeptedName, new AddAndViewProduct(driver).GetPrNameId());
        }
    }
}
