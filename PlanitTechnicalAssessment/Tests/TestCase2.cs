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
    public class TestCase2 : BasePage
    {
        [Test]
        public void TestCaseTwo()
        {
            var forename = "Faisal";

            //Go to Contact Page
            var contactPage = new ContactPage(_driver);
            contactPage.ClickContactHeader();

            //Populate Mandatory Fields
            contactPage.PopulateMandatoryFields(forename, "testingemail@hotmail.com", "I love this Technical Assessment.");

            //Click the Submit Button
            contactPage.ClickSubmitButton();

            //Validate Successful Submission Message
            contactPage.ValidateSuccessfullSubmissionMessage(forename);
        }
    }
}
