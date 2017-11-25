using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumProjekt
{
    class LobSelectionPage : POModel
    {
        private IWebDriver driver;
      
    public enum lob {Auto, HO3, HO4, HO6, MH, Motorcylce, Watercraft, Pet, BOP, GL, EnO, WC, Umbrella, DF }
        public LobSelectionPage(IWebDriver driver) : base(driver)
        {
        }


        public void Zip(string zip)
        {
            IWebElement zipField = getElement(xType.css, "#ng-app > div:nth-child(5) > div > div.chars.container > div:nth-child(2) > section > div.pageInfo.appInfo.clearPage > fieldset > div:nth-child(1) > div > div.products > div > div > div:nth-child(1) > div.zip-code.ng-isolate-scope > div > div:nth-child(2) > input");
            zipField.Click();
            zipField.SendKeys(zip);
           

        }

        public IWebElement SelectLob(lob lob)
        {
            IWebElement element;
            switch(lob)
            {
                case lob.Auto:
                    {
                        element = getElement(xType.css, "#ng-app > div:nth-child(5) > div > div.chars.container > div:nth-child(2) > section > div.pageInfo.appInfo.clearPage > fieldset > div:nth-child(1) > div > div.ng-isolate-scope > div.ng-isolate-scope > div > div > div > div > label");
                        break;
                    }
                case lob.DF:
                    {
                        element = getElement(xType.css, "#ng-app > div:nth-child(5) > div > div.chars.container > div:nth-child(2) > section > div.pageInfo.appInfo.clearPage > fieldset > div:nth-child(1) > div > div.ng-isolate-scope > div.products > div:nth-child(1) > div > div > div:nth-child(3) > div > label");
                        break;
                    }
                case lob.HO3:
                    {
                        element = getElement(xType.css, "#ng-app > div:nth-child(5) > div > div.chars.container > div:nth-child(2) > section > div.pageInfo.appInfo.clearPage > fieldset > div:nth-child(1) > div > div.ng-isolate-scope > div.products > div:nth-child(1) > div > div > div:nth-child(1) > div > label");
                        break;
                    }
                case lob.HO4:
                    {
                        element = getElement(xType.css, "#ng-app > div:nth-child(5) > div > div.chars.container > div:nth-child(2) > section > div.pageInfo.appInfo.clearPage > fieldset > div:nth-child(1) > div > div.ng-isolate-scope > div.products > div:nth-child(1) > div > div > div:nth-child(4) > div > label");
                        break;
                    }
                case lob.HO6:
                    {
                        element = getElement(xType.css, "#ng-app > div:nth-child(5) > div > div.chars.container > div:nth-child(2) > section > div.pageInfo.appInfo.clearPage > fieldset > div:nth-child(1) > div > div.ng-isolate-scope > div.products > div:nth-child(1) > div > div > div:nth-child(2) > div > label");
                        break;
                    }
                case lob.MH:
                    {
                        element = getElement(xType.xpath, "DFxpath");
                        break;
                    }
                case lob.Motorcylce:
                    {
                        element = getElement(xType.css, "#ng-app > div:nth-child(5) > div > div.chars.container > div:nth-child(2) > section > div.pageInfo.appInfo.clearPage > fieldset > div:nth-child(1) > div > div.ng-isolate-scope > div.products > div:nth-child(2) > div > div > div:nth-child(1) > div > label");
                        break;
                    }
                case lob.Pet:
                    {                                    
                        element = getElement(xType.css, "#ng-app > div:nth-child(5) > div > div.chars.container > div:nth-child(2) > section > div.pageInfo.appInfo.clearPage > fieldset > div:nth-child(1) > div > div.ng-isolate-scope > div.products > div:nth-child(2) > div > div > div:nth-child(3) > div > label");
                        break;
                    }
                case lob.Umbrella:
                    {
                        element = getElement(xType.xpath, "DFxpath");
                        break;
                    }
                case lob.GL:
                    {
                        element = getElement(xType.xpath, "DFxpath");
                        break;
                    }
                case lob.EnO:
                    {
                        element = getElement(xType.xpath, "DFxpath");
                        break;
                    }
                case lob.BOP:
                    {
                        element = getElement(xType.xpath, "DFxpath");
                        break;
                    }
                case lob.Watercraft:
                    {
                        element = getElement(xType.css, "#ng-app > div:nth-child(5) > div > div.chars.container > div:nth-child(2) > section > div.pageInfo.appInfo.clearPage > fieldset > div:nth-child(1) > div > div.ng-isolate-scope > div.products > div:nth-child(2) > div > div > div:nth-child(2) > div > label");
                        break;
                    }
                case lob.WC:
                    {
                        element = getElement(xType.xpath, "DFxpath");
                        break;
                    }




                default:
                    element = null;
                    break;
            }
            return element;
            
        }
        



    }
}
