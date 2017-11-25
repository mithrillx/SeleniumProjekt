using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using System.Threading;
using SeleniumProjekt.Pages;

namespace SeleniumProjekt
{
    class Program : boltLanding
    {
        public Program(IWebDriver driver) : base(driver)
        {
        }

        static void Main(string[] args)
        {
            
            IWebDriver driver = new ChromeDriver();
            boltLanding x = new boltLanding(driver);
            x.getHere();
            x.startAutoQuote();
            LobSelectionPage LobSelection = new LobSelectionPage(driver);
            LobSelection.Zip("93230");
            LobSelection.SelectLob(LobSelectionPage.lob.Auto);
            Thread.Sleep(2000);
            LobSelection.nextPage();
            ApplicantInfo Applicantinfo = new ApplicantInfo(driver);
            Applicantinfo.fillPersonalDetials("", "s", "s", "s", "s", "s");







        }
    }
    }

