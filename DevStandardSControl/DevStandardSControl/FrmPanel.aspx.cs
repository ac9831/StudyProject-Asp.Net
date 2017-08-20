using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardSControl
{
    public partial class FrmPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                Page.SetFocus(txtMessage);
            }

            this.pnlFirst.Visible = true;
            this.pnlSecond.Visible = false;
            btnShowPanel1.Visible = false;
            btnShowPanel2.Visible = true;
        }

        protected void btnShowPanel1_Click(object sender, EventArgs e)
        {
            this.pnlFirst.Visible = true;
            this.pnlSecond.Visible = false;
            btnShowPanel1.Visible = false;
            btnShowPanel2.Visible = true;
            SetFocus(txtMessage);
            pnlCommand.DefaultButton = "btnShowPanel2";
        }

        protected void btnShowPanel2_Click(object sender, EventArgs e)
        {
            this.pnlFirst.Visible = false;
            this.pnlSecond.Visible = true;
            btnShowPanel1.Visible = true;
            btnShowPanel2.Visible = false;
            SetFocus(txtMessage);
            pnlCommand.DefaultButton = "btnShowPanel1";
        }
    }
}