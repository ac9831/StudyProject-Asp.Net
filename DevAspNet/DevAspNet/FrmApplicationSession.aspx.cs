using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevAspNet
{
    public partial class FrmApplicationSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Application["Count"] == null)
            {
                Application.Lock();
                Application["Count"] = 1;
                Application.UnLock();
            }
            else
            {
                Application["Count"] = (int)Application["Count"] + 1;
            }

            if (Session["Count"] == null)
            {
                Session["Count"] = 1;
            }
            else
            {
                Session["Count"] = (int)Session["Count"] + 1;
            }

            this.lblApplication.Text = Application["Count"].ToString();
            this.lblSession.Text = Session["Count"].ToString();
            this.lblSessionID.Text = Session.SessionID;
            this.lblTimeout.Text = Session.Timeout.ToString();
        }
    }
}