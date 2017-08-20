using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class FrmDropDownListWithRequiredFieldValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                DropDownList1.Items.Insert(0, new ListItem("-선택-", "-1"));

                for(int i=0; i<10;i++)
                {
                    ListItem li = new ListItem(i.ToString(), String.Format("{0}", i));
                    this.DropDownList1.Items.Add(li);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue;
        }
    }
}