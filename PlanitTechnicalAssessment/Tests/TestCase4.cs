using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PlanitTechnicalAssessment.Base;
using PlanitTechnicalAssessment.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanitTechnicalAssessment.Tests
{
    [TestFixture]
    public class TestCase4 : BasePage
    {
        [Test]
        public void TestCaseFour()
        {
            //Go to Shop Page
            var shopPage = new ShopPage(_driver);
            shopPage.ClickShopHeader();

            //Click buy button 2 times for Funny Cow Product
            shopPage.BuyProductWithQuantity(shopPage.FunnyCow, 2);

            //Click buy button 1 time for Fluffy Bunny Product
            shopPage.BuyProductWithQuantity(shopPage.FluffyBunny, 1);

            //Go to Cart Menu/Page
            shopPage.ClickCartHeader();

            //Verify Cart Items
            var cartPage = new CartPage(_driver);
            var expectedData = new List<List<string>>() { 
                new List<string> { "Funny Cow", "$10.99", "2", "$21.98" }, 
                new List<string> { "Fluffy Bunny", "$9.99", "1", "$9.99" } 
            };

            cartPage.VerifyCartItems(expectedData);
        }
    }
}
