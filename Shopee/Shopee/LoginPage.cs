using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee
{
    class LoginPage : Common
    {
        #region Element

        internal WebTextbox UserNameTextbox => new WebTextbox(findElement("CS~input[name=userName]"));

        internal WebTextbox PasswordTextbox => new WebTextbox(findElement("CS~input[name=password]"));

        internal WebButton LoginButton => new WebButton(findElement("CS~input[name=login]"));

        #endregion

        #region Getter Setter

        internal string UserName
        {
            get { return UserNameTextbox.Value; }
            set { UserNameTextbox.Input(value); }
        }

        internal string Password
        {
            get { return PasswordTextbox.Value; }
            set { PasswordTextbox.Input(value); }
        }

        #endregion

        #region Method

        public void Click_login_button()
        {
            LoginButton.Click();
        }

        public bool Wait_until_find_flight_page()
        {
            return explicitWaitUntilVisible("CS~form[name='findflight']");
        }

        #endregion
    }
}
