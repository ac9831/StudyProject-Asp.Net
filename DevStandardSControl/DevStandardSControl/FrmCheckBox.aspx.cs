using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardSControl
{
    public partial class FrmCheckBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            string strMsg = "선택한 값:<br />";
            if(this.chkCSharp.Checked)
            {
                strMsg += chkCSharp.Text + "<br />";
            }
            if(this.chkAspNet.Checked)
            {
                strMsg += chkAspNet.Text + "<br />";
            }
            lblDisplay.Text = strMsg;
        }
    }
}