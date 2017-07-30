using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardSControl
{
    public partial class FrmTextBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string strName = this.txtSingleLine.Text;
            string strIntro = this.txtMultiLine.Text;
            string strPassword = this.txtPassword.Text;
            Response.Write(strName + "<br />" + strIntro + "<br />" + strPassword + "<br />");
        }
    }
}