using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    [TestFixture]
    class Test : TestBase
    {
        [Test]
        public void Test_login_function()
        {
            var Login = new LoginPage();
            Login.UserName = "shopeetest";
            Login.Password = "Shopee@2020";

            Login.Click_login_button();
            Login.Wait_until_find_flight_page();

            Assert.AreEqual(Login.Get_title(), "Find a Flight: Mercury Tours:");
        }
    }
}
