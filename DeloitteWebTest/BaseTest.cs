﻿using DeloitteWeb;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace DeloitteTest
{
    [TestFixture]


    public class BaseTest
    {

        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected string baseURL;
        protected LoginPage LoginPageInstance;
        protected ProjectsPage ProjectsPageInstance;

        [OneTimeSetUp]

        public void OneTimeSetUp()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            baseURL = "https://perf.exalinkservices.com";

        }

        [TearDown]
        public void TearDown()
        {
            //Log out from app

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
