using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumProjekt.Pages
{
    class BoltADB : POModel
    {
        
        IWebDriver driver;
        public BoltADB(IWebDriver driver) : base(driver)
        {
        }

        public void login(string user, string pass)
        {
            getElement(xType.css, "#txtId").SendKeys(user);
            getElement(xType.css, "#txtPassword").SendKeys(pass);
            getElement(xType.css, "#btnLogin").Click();
        }
        public void getHere()
        {
           open("https://agencytest.superioraccessqa.com");
        }


        public void StartNewQuote(LineOfBusiness lob)
        {
            getElement(xType.css, "#hypGetQuotes > span").Click();

            switch (lob)
            {
                case LineOfBusiness.PL:
                    {
                        ClickJS(getElement(xType.css, "#PnlQuote]"));
                        //getElement(xType.xpath, "//*[@id='PnlQuote']").Click();
                        break;
                    }
                case LineOfBusiness.CL:
                    {
                        getElement(xType.id, "CmmlQuote").Click();
                        break;
                    }

                        default:
                    break;
            }
            getElement(xType.id, "NewQuote").Click();
            getElement(xType.css, "#NewClient > p > span").Click();
        }



        public enum LineOfBusiness { CL,PL}
    }
}
