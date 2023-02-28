using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PlanitTechnicalAssessment.Base;
using PlanitTechnicalAssessment.Helpers;
using PlanitTechnicalAssessment.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlanitTechnicalAssessment.Tests
{
    [TestFixture]
    public class TestCase1 : BasePage
    {
        [Test]
        public void TestCaseOne()
        {
            //Go to Contact Page
            var contactPage = new ContactPage(_driver);
            contactPage.ClickContactHeader();

            //Click the Submit Button
            contactPage.ClickSubmitButton();

            //Validate errors
            contactPage.ValidateMandatoryFormErrorsAreDisplayed(true);

            //Populate Mandatory Fields
            contactPage.PopulateMandatoryFields("Faisal", "testingemail@hotmail.com", "I love this Technical Assessment.");

            //Validate Errors are gone
            contactPage.ValidateMandatoryFormErrorsAreDisplayed(false);
        }
    }
}
