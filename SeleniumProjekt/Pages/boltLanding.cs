using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using System.Collections.ObjectModel;



namespace SeleniumProjekt 
{
    class boltLanding : POModel
    {

        private IWebDriver driver;

        string Home = "https://www.boltinsurance.com/";



        public boltLanding(IWebDriver driver) : base(driver)
        {
        }

        public void getHere()
        {

            open("https://www.boltinsurance.com/");
            
        }

        public void startAutoQuote()
        {
            var Auto = getElement(xType.xpath, "//*[@id='sliderbanner']/div/div/div/div/div/div/span/div/div[1]/ul/li[1]/a/img[1]");
            var start = getElement(xType.css, "#gt-qt");
            Auto.Click();
            start.Click();
        }


    }
}
