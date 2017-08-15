using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardSControl
{
    public partial class FrmLiteral : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctlDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }
    }
}