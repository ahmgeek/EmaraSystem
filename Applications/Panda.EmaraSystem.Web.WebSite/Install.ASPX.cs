﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
public partial class Install : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Membership.CreateUser("admin", "1234");
        Roles.CreateRole("Admin");
        Roles.AddUserToRole("admin", "admin");

    }
}