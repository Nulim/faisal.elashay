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
    public class TestCase3 : BasePage
    {

        [Test]
        public void TestCaseThree()
        {
            //Go to Contact Page
            var contactPage = new ContactPage(_driver);
            contactPage.ClickContactHeader();

            //Populate Mandatory Fields
            contactPage.PopulateMandatoryFields("    ", "InvalidEmail123", "   ");

            //Validate errors
            contactPage.ValidateMandatoryFormErrorsAreDisplayed(true);
        }
    }
}
