using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardSControl
{
    public partial class FrmFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (ctlFileUpload.HasFile)
            {
                ctlFileUpload.SaveAs(Server.MapPath(".") + "\\files\\" + ctlFileUpload.FileName);
                lblResult.Text = String.Format("<a href='{0}{1}'>{1}</a>", "./files/", Server.UrlEncode(ctlFileUpload.FileName));
            }
        }
    }
}