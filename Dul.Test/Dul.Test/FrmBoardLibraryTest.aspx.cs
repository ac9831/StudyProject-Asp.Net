﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dul.Test
{
    public partial class FrmBoardLibraryTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = Dul.BoardLibrary.ConvertToFileSize(Convert.ToInt32(txtInput.Text));
        }
    }
}