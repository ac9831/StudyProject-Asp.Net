﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardSControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            string s = "";
            s += this.txtStart.Text + "<br />";
            s += this.txtStep1.Text + "<br />";
            s += this.txtStep2.Text + "<br />";
            s += this.txtFinish.Text + "<br />";
            this.lblComplete.Text = s;
        }
    }
}