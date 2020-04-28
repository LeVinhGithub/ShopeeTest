using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    class WebTextbox : Common
    {
        IWebElement Element;

        public WebTextbox(IWebElement element)
        {
            Element = element;
        }

        public void Input(string value)
        {
            Element.Clear();
            Element.SendKeys(value);
        }

        public string Value
        {
            get { return Element.Text; }
        }
    }
}
