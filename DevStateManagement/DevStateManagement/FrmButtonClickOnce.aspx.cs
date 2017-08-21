using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStateManagement
{
    public partial class FrmButtonClickOnce : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if(Session["ClickTime"] != null)
            {
                DateTime originDate = Convert.ToDateTime(Session["ClickTime"]);

                TimeSpan objTs = DateTime.Now - originDate;
                if(objTs.TotalSeconds < 5)
                {
                    lblDisplay.Text = "잠시 대기할게요";
                    return;
                }
            }
            Session["ClickTime"] = DateTime.Now;
            lblDisplay.Text = txtInput.Text;
        }
    }
}