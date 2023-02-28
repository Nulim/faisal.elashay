using NUnit.Framework;
using OpenQA.Selenium;
using PlanitTechnicalAssessment.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanitTechnicalAssessment.Pages
{
    public class CartPage
    {
        private readonly WebDriver? _driver;

        public CartPage(WebDriver driver) => _driver = driver;

        public void VerifyCartItems(List<List<string>> expectedRowsData)
        {
            var numberOfRows = _driver?.WaitAndFindElements(By.XPath("//tbody/tr")).Count;
            var rowData = FormatTableDataIntoRowDataCollection(numberOfRows);

            Assert.AreEqual(expectedRowsData, rowData, $"The expected result was not found in the actual result. Please review the data again.");
        }

        private List<List<string>> FormatTableDataIntoRowDataCollection(int? numberOfRows)
        {
            var rows = new List<List<string>>();

            for (int i = 1; i <= numberOfRows; i++)
            {
                var rowData = _driver?.WaitAndFindElements(By.XPath($"//tbody/tr[{i}]/td")); //Get all Row Data Elements
                var textData = new List<string>();

                foreach (var item in rowData)
                {
                    //Get quantity value via attribute 
                    if (rowData.IndexOf(item) == 2)
                    {
                        textData.Add(_driver.WaitAndFindElement(By.XPath($"//tbody/tr[{i}]/td/input")).GetAttribute("value"));
                    }
                    else if (rowData.IndexOf(item) != 4) //Item position 4 is skipped as it is the remove item action element
                    {
                        textData.Add(item.Text); //store column text
                    }
                }

                rows.Add(textData);
            }

            return rows;
        }
    }
}
