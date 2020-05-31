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
        [Given (@"I open ""(.*)"" url")]
        public void GivenIOpenUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;
        }

        [When(@"I set login ""(.*)""")]
        public void WhenISetLogin(string login)
        {
            new Login(driver).SetLogin(new AvtorizateData(login, null));
        }

        [When(@"I set password ""(.*)""")]
        public void WhenISetPassword(string password)
        {
            new Login(driver).SetPassword(new AvtorizateData(null, password));
        }

        [When(@"I click on button ""(.*)""")]
        public void WhenIClickOnButton(string button)
        {
            new AllProducts(driver).ClickOnNorthWind(new Headers(button, null, null, null));
        }

        [When(@"I click on create new")]
        public void WhenIClickOnCreateNew()
        {
            new AllProducts(driver).ClickOnCreate();
        }

        [When(@"I set name of product ""(.*)""")]
        public void WhenISetNameOfProduct(string name)
        {
            new AddAndViewProduct(driver).SetPrName(new Product(name, null, null, null, null, null, null, null, null, null, null));
        }

        [When(@"I set category ""(.*)""")]
        public void WhenISetCategory(string cat)
        {
            new AddAndViewProduct(driver).SetCat(new Product(null, null, cat, null, null, null, null, null, null, null, null));
        }

        [When(@"I set supplier ""(.*)""")]
        public void WhenISetSupplier(string sup)
        {
            new AddAndViewProduct(driver).SetSup(new Product(null, null, null, null, sup, null, null, null, null, null, null));
        }

        [When(@"I set unitPrice ""(.*)""")]
        public void WhenISetUnitPrice(string unitPrice)
        {
            new AddAndViewProduct(driver).SetPrice(new Product(null, null, null, null, null, unitPrice, null, null, null, null, null));
        }

        [When(@"I set quantityPerUnit ""(.*)""")]
        public void WhenISetQuantityPerUnit(string quantityPerUnit)
        {
            new AddAndViewProduct(driver).SetQuantity(new Product(null, null, null, null, null, null, null, quantityPerUnit, null, null, null));
        }

        [When(@"I set unitsInStock ""(.*)""")]
        public void WhenISetUnitsInStock(string unitsInStock)
        {
            new AddAndViewProduct(driver).SetStock(new Product(null, null, null, null, null, null, null, null, unitsInStock, null, null));
        }

        [When(@"I set unitsOnOrder ""(.*)""")]
        public void WhenISetUnitsOnOrder(string unitsOnOrder)
        {
            new AddAndViewProduct(driver).SetOrder(new Product(null, null, null, null, null, null, null, null, null, unitsOnOrder, null));
        }

        [When(@"I set reorderLevel ""(.*)""")]
        public void WhenISetReorderLevel(string reorderLevel)
        {
            new AddAndViewProduct(driver).SetLvl(new Product(null, null, null, null, null, null, null, null, null, null, reorderLevel));
        }

        [Then(@"Page have product ""(.*)""")]
        public void ThenPagesHeaderShouldBe(string exeptedHeader)
        {
            Assert.AreEqual(exeptedHeader, new AddAndViewProduct(driver).GetPrName());
        }
    }
}
