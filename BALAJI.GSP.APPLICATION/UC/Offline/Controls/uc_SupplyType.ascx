﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_SupplyType.ascx.cs" Inherits="BALAJI.GSP.APPLICATION.UC.Offline.Controls.uc_SupplyType" %>
<td><asp:DropDownList ID="ddlPos" OnSelectedIndexChanged="ddlPos_SelectedIndexChanged" CssClass="form-control input-sm" AutoPostBack="true" runat="server"></asp:DropDownList></td>
<td><asp:DropDownList ID="ddlSupplyType" AutoPostBack="true" CssClass="form-control input-sm" disabled runat="server"></asp:DropDownList></td>