using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    class WebButton : Common
    {
        IWebElement Element;

        public WebButton(IWebElement element)
        {
            Element = element;
        }

        public void Click()
        {
            Element.Click();
        }
    }
}
