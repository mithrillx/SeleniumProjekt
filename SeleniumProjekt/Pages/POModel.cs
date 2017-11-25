using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProjekt
{
    class POModel
    {


        public enum xType { xpath = 1, css = 2, id = 3, name = 4 }

        IWebDriver driver;

        public void open(string url)
        {
            driver.Navigate().GoToUrl(url);
        
        }
        public POModel(IWebDriver driver)
        {
            this.driver = driver;
        }
            
        
        public IWebElement getElement(xType type, string path)
        {
            IWebElement element = null;
            WebDriverWait wait;
            switch (type)
            {
                case xType.xpath:
                    {
                        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                        element = wait.Until<IWebElement>(d => d.FindElement(By.XPath(path)));
                        return element;
                    }
                case xType.css:
                    {
                        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                        element = wait.Until<IWebElement>(d => d.FindElement(By.CssSelector(path)));
                        return element;
                    }
                case xType.name:
                    {
                        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                        element = wait.Until<IWebElement>(d => d.FindElement(By.Name(path)));
                        return element;
                    }

                case xType.id:
                    {
                        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                        element = wait.Until<IWebElement>(d => d.FindElement(By.Id(path)));
                        return element;
                    }
                default:
                    return element;

            }
        }


        public void nextPage()
        {
            //not clickable through selenium, used js exec
            IWebElement NextPageBtn = getElement(xType.css, "#ng-app > div:nth-child(5) > div > div.chars.container > div:nth-child(3) > div > div.mess-quote.saveCont > a");
            ClickJS(NextPageBtn);
        }

        public void ClickJS(IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
        }
       
    }
}
