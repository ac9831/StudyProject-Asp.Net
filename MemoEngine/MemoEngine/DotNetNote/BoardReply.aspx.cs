﻿using System;
using DotNetNote.Models;

namespace MemoEngine.DotNetNote
{
    public partial class BoardReply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctlBoardEditorFormControl.FormType = BoardWriteFormType.Reply;
        }
    }
}