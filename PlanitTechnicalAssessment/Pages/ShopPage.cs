using OpenQA.Selenium;
using PlanitTechnicalAssessment.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanitTechnicalAssessment.Pages
{
    public class ShopPage
    {
        private readonly WebDriver? _driver;

        public ShopPage(WebDriver driver) => _driver = driver;

        public IWebElement? ShopHeader => _driver?.WaitAndFindElement(By.Id("nav-shop"));
        public IWebElement? Cart => _driver?.WaitAndFindElement(By.Id("nav-cart"));
        public IWebElement? FunnyCow => _driver?.WaitAndFindElement(By.XPath("//h4[contains(text(), 'Funny Cow')]/..//a"));
        public IWebElement? FluffyBunny => _driver?.WaitAndFindElement(By.XPath("//h4[contains(text(), 'Fluffy Bunny')]/..//a"));


        public void ClickShopHeader() => ShopHeader?.Click();

        public void ClickCartHeader() => Cart?.Click();

        public void BuyProductWithQuantity(IWebElement product, int quantity)
        {
            for(int i = 0; i < quantity; i++)
                product.Click();
        }

    }
}
