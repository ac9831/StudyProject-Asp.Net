﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BoardWrite.aspx.cs" ValidateRequest="false" Inherits="MemoEngine.DotNetNote.BoardWrite" %>

<%@ Register Src="~/DotNetNote/Controls/BoardEditorFormControl.ascx" TagPrefix="ucl" TagName="BoardEditorFormControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <ucl:BoardEditorFormControl runat="server" ID="ctlBoardEditorFormControl" />
</asp:Content>
