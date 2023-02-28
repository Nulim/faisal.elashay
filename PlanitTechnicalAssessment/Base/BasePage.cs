using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PlanitTechnicalAssessment.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanitTechnicalAssessment.Base
{
    public class BasePage
    {
        public static WebDriver? _driver;
        public static string? _url;

        [SetUp]
        public void Setup()
        {
            //Get AppSettings from Settings.json file
            var AppSettings = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Settings.json")
                .Build()
                .GetSection("AppSettings");

            _driver = BrowserHelper.SetBrowserType(AppSettings["browserType"]);
            _url = AppSettings["websiteUrl"];

            //Go to Home Page
            _driver?.Navigate().GoToUrl(_url);
            _driver?.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown() => _driver?.Quit();
    }
}
