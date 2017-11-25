using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProjekt.Pages
{
    class ApplicantInfo : POModel
    {

        private IWebDriver driver;
        public ApplicantInfo(IWebDriver driver) : base(driver)
        {
        }

        public void fillPersonalDetials(string FirstName, string LastName, string Email, string DOB, string PhoneNumber,string Address)
        {
            getElement(xType.css, "#ng-app > div:nth-child(5) > div > div.chars.container > div:nth-child(2) > section > div.pageInfo.appInfo > fieldset > div:nth-child(1) > div > div:nth-child(3) > div > div:nth-child(1) > div:nth-child(1) > div > div:nth-child(2) > input").SendKeys(FirstName);

        }
    }
}
