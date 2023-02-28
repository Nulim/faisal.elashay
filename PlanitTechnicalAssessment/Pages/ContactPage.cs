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
    public class ContactPage
    {
        private readonly WebDriver? _driver;

        public ContactPage(WebDriver driver) => _driver = driver;

        public IWebElement? ContactHeader => _driver?.WaitAndFindElement(By.Id("nav-contact"));
        public IWebElement? SubmitButton => _driver?.WaitAndFindElement(By.XPath("//a[@class='btn-contact btn btn-primary' and contains(text(),'Submit')]"));
        public IWebElement? Forename => _driver?.WaitAndFindElement(By.Id("forename"));
        public IWebElement? Email => _driver?.WaitAndFindElement(By.Id("email"));
        public IWebElement? Message => _driver?.WaitAndFindElement(By.Id("message"));
        public IWebElement? SubmissionMessage => _driver?.WaitAndFindElement(By.XPath("//*[@class='alert alert-success']/strong"));



        public void ClickSubmitButton() => SubmitButton?.Click();

        public void ClickContactHeader() => ContactHeader?.Click();

        public void ValidateMandatoryFormErrorsAreDisplayed(bool isDisplayed)
        {
            foreach (var errorId in new[] { "forename-err", "email-err", "message-err" })
            {
                if(isDisplayed)
                    Assert.IsTrue(_driver?.WaitAndFindElement(By.Id(errorId)).Displayed, $"The '{errorId}' field error is not displayed.");
                else
                    Assert.IsTrue(_driver?.VerifyElementDoesNotExist(By.Id(errorId)), $"The '{errorId}' field has not been filled in correctly. Please review your input and try again.");
            }
        }

        public void PopulateMandatoryFields(string forename, string email, string message)
        {
            Forename?.SendKeys(forename);
            Email?.SendKeys(email);
            Message?.SendKeys(message);
        }

        public void ValidateSuccessfullSubmissionMessage(string forename) => Assert.AreEqual(SubmissionMessage?.Text, $"Thanks {forename}");

    }
}
