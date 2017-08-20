using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardSControl
{
    public partial class FrmMultiView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ctlMultiView1.ActiveViewIndex = 0;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            this.ctlMultiView1.ActiveViewIndex = 1;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            this.ctlMultiView1.ActiveViewIndex = 0;
        }
    }
}