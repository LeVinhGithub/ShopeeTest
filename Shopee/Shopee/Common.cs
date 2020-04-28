using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    public class Common
    {
        public static IWebDriver driver;

        public static void StartDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            driver.Navigate().GoToUrl("http://newtours.demoaut.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void Finish_driver()
        {
            driver.Quit();
        }

        public By _By(string locator)
        {
            Char splitchar = '~';
            String[] type = locator.Split(splitchar);
            locator = type[1];

            switch (type[0])
            {
                case "ID":
                    return By.Id(locator);
                case "CL":
                    return By.ClassName(locator);
                case "NA":
                    return By.Name(locator);
                case "TA":
                    return By.TagName(locator);
                case "LI":
                    return By.LinkText(locator);
                case "PA":
                    return By.PartialLinkText(locator);
                case "CS":
                    return By.CssSelector(locator);
                case "XP":
                    return By.XPath(locator);
                default:
                    return null;
            }
        }

        public WebDriverWait setWaitDriver()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            return wait;
        }

        public IWebElement findElement(string locator)
        {
            return setWaitDriver().Until(SeleniumExtras.WaitHelpers
                                        .ExpectedConditions.ElementIsVisible
                                        (_By(locator)));
        }

        public bool explicitWaitUntilVisible(string locator)
        {
            try
            {
                setWaitDriver().Until(SeleniumExtras.WaitHelpers
                                        .ExpectedConditions.ElementIsVisible
                                        (_By(locator)));
                return true;
            }
            catch
            {
                Console.WriteLine("This element is not visible!");
                return false;
            }
        }

        public string Get_title()
        {
            return driver.Title;
        }
    }
}
