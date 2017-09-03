using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dul.Test
{
    public partial class FrmStringLibraryTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCut_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = Dul.StringLibrary.CutStringUnicode(txtInput.Text, 6);
            lblDisplay.Text = txtInput.Text.CutStringUnicode(6);
        }
    }
}