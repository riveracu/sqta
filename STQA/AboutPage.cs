﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STQA
{
        class AboutPage
        {
            private IWebDriver driver;
            private WebDriverWait wait;

            public AboutPage(IWebDriver driver)
            {
                this.driver = driver;
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                PageFactory.InitElements(driver, this);
            }

        [FindsBy(How = How.CssSelector, Using = "#sidebar input[class='s']")]
        private IWebElement searchText;
        [Obsolete("killo no lo uses")]
        public ResultPage search(string text)
        {
            searchText.SendKeys(text);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#sidebar .searchsubmit"))).Click();
            return new ResultPage(driver);
        }
    }
}
