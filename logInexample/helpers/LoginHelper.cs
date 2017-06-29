using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace logInexample.helpers
{
    public class LoginHelper
    {
        static public bool isLoggedIn()
        {
            if (HttpContext.Current.Session["LoginID"] == null)
            {
                return false;
            }
            else
            {
                // there is a session ID
                return true;

            }

        }

        static public void CheckLogin()
        {
            if (!isLoggedIn())
            {
                HttpContext.Current.Response.Redirect("~/Login");

            }

        }
    }
}