using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardSControl
{
    public partial class FrmListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                this.lstHobby.Items.Add("축구");
                this.lstHobby.Items.Add("농구");

                ListItem li = new ListItem();
                li.Text = "배구";
                li.Value = "Volleyball";
                lstHobby.Items.Add(li);
            }
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            string strMsg = String.Empty;
            for(int i=0;i<lstHobby.Items.Count; i++)
            {
                if(lstHobby.Items[i].Selected)
                {
                    strMsg += lstHobby.Items[i].Text;
                    if (i != lstHobby.Items.Count - 1)
                    {
                        strMsg += ", ";
                    }
                }
                
            }
            lblDisplay.Text = strMsg;
        }
    }
}