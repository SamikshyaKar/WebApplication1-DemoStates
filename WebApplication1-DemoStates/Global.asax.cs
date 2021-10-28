﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1_DemoStates
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

            Application["TotalApplications"] = 0;
            Application["TotalUserSessions"] = 0;
            Application["TotalApplications"] = (int)Application["TotalApplications"] + 1;
        }

        void Session_Start(Object sender, EventArgs e)

        {

            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] + 1;


        }

        void Session_End(Object sender, EventArgs e)
        {

            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] - 1;

        }
    }
}