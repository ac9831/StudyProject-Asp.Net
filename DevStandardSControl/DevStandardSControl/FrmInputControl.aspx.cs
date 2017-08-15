using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace DevStandardSControl
{
    public partial class FrmInputControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                BindFavorite();
            }
        }

        private void BindFavorite()
        {
            lstFavorite.Items.Add("C#");
            this.lstFavorite.Items.Add("ASP.NET");

            ListItem li = new ListItem();
            li.Text = "JavaScript";
            li.Value = "TypeScript";
            this.lstFavorite.Items.Add(li);

            ListItem listItem = new ListItem("닷컴", ".NET");
            this.lstFavorite.Items.Add(listItem);
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if(this.chkAgree.Checked)
            {
                sb.Append("[1] " + this.chkAgree.Text + "<br />");
            }

            if(this.lstHobby.Items[0].Selected)
            {
                sb.Append("[2] " + this.lstHobby.Items[0].Value + "<br />");
            }
            if(this.lstHobby.Items[1].Selected)
            {
                sb.AppendFormat("[2] {0}<br />", this.lstHobby.Items[1].Value);
            }

            if(this.lstHobby.Items[2].Selected)
            {
                sb.AppendFormat("[2] {0}<br />", this.lstHobby.Items[2].Value);
            }

            if(this.rdoMan.Checked)
            {
                sb.AppendFormat("[3] {0} 선택<br />", rdoMan.Text);
            }
            else
            {
                sb.AppendFormat("[3] {0} 선택<br />", rdoWomen.Text);
            }

            sb.AppendFormat("[4] {0} <br />", lstWedding.SelectedItem.Text);
            sb.AppendFormat("[5] {0} <br />", lstJob.Items[lstJob.SelectedIndex].Value);

            for(int i = 0; i< lstFavorite.Items.Count; i++)
            {
                if(lstFavorite.Items[i].Selected)
                {
                    sb.AppendFormat("[6] {0}<br />", lstFavorite.Items[i].Value);
                }
            }
            
            foreach(ListItem li in lstFavorite.Items)
            {
                if(li.Selected)
                {
                    sb.AppendFormat("[6] {0}<br />", li.Text);
                }
            }

            this.lblDisplay.Text = sb.ToString();
        }


    }
}