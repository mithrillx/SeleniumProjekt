using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using SeleniumProjekt.Pages;
using System.Globalization;

namespace SeleniumProjekt
{
    class Tests 
    {
        IWebDriver driver;
        DateTime time = new DateTime();
        [SetUp]
        public void testStart()
        {
            Console.WriteLine(DateTime.Now.ToString() + " start of Test");
        }

        [Test]
        public void ss()
        {
            driver = new ChromeDriver();
            boltLanding x = new boltLanding(driver);
            x.getHere();
            x.startAutoQuote();
            LobSelectionPage LobSelection = new LobSelectionPage(driver);
            LobSelection.Zip("93230");
            LobSelection.ClickJS(LobSelection.SelectLob(LobSelectionPage.lob.Auto)); ;
            LobSelection.ClickJS(LobSelection.SelectLob(LobSelectionPage.lob.HO3)); ;
            //LobSelection.SelectLob(LobSelectionPage.lob.Pet);
            LobSelection.ClickJS(LobSelection.SelectLob(LobSelectionPage.lob.Pet));
              
            Thread.Sleep(2000);
            LobSelection.nextPage();
            ApplicantInfo Applicantinfo = new ApplicantInfo(driver);
            Applicantinfo.fillPersonalDetials("eeee", "s", "s", "s", "s", "s");
        }

        [Test]
        public void dd()
        {
            driver = new ChromeDriver();
            boltLanding x = new boltLanding(driver);
            x.getHere();
            x.startAutoQuote();
            LobSelectionPage LobSelection = new LobSelectionPage(driver);
            LobSelection.Zip("90210");
            LobSelection.SelectLob(LobSelectionPage.lob.Auto).Click();
            LobSelection.SelectLob(LobSelectionPage.lob.HO3).Click();
            //LobSelection.SelectLob(LobSelectionPage.lob.Pet);
            LobSelection.ClickJS(LobSelection.SelectLob(LobSelectionPage.lob.Pet));

            Thread.Sleep(2000);
            LobSelection.nextPage();
            ApplicantInfo Applicantinfo = new ApplicantInfo(driver);
            Applicantinfo.fillPersonalDetials("gong", "s", "s", "s", "s", "s");
        }


        [TearDown]
        public void TearDown()
        {
            Console.WriteLine(DateTime.Now.ToString() + "end of Test");
        }
    }
}
