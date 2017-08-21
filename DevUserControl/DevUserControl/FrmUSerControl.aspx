<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmUSerControl.aspx.cs" Inherits="DevUserControl.FrmUSerControl" %>

<%@ Register Src="~/NavigatorUserControl.ascx" TagPrefix="ucl" TagName="NavigatorUserControl" %>
<%@ Register Src="~/CategoryUserControl.ascx" TagPrefix="ucl" TagName="CategoryUserControl" %>
<%@ Register Src="~/CatalogUserControl.ascx" TagPrefix="ucl" TagName="CatalogUserControl" %>
<%@ Register Src="~/CopyrightUserControl.ascx" TagPrefix="ucl" TagName="CopyrightUserControl" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>웹 사이트 뼈대 만들기</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style>
        div {
            border: 1px solid red;
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <ucl:NavigatorUserControl runat="server" id="NavigatorUserControl" />
                </div>
            </div>
            <div class="row" style="height:200px;">
                <div class="col-md-3">
                    <ucl:CategoryUserControl runat="server" id="CategoryUserControl" />
                </div>
                <div class="col-md-9">
                    <ucl:CatalogUserControl runat="server" id="CatalogUserControl" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <ucl:CopyrightUserControl runat="server" id="CopyrightUserControl" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
