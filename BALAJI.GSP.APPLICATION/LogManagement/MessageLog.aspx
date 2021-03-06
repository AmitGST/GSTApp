﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="MessageLog.aspx.cs" Inherits="BALAJI.GSP.APPLICATION.LogManagement.MessageLog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="content-header">
        <h1>Message Log</h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Log Management</a></li>
            <li class="active">Message Log</li>
        </ol>
    </div>
       <div class="content">
        <div class="box box-primary">
            <div class="box-header with-border">
                <h3 class="box-title">Message Log</h3>
            </div>
            <div class="box-body">
            <asp:ListView ID="lv_MessageLog" OnPagePropertiesChanging="lv_MessageLog_PagePropertiesChanging" runat="server">
             <EmptyDataTemplate>
                   <table class="table ">
                                    <tr>
                                        <td>No data was returned.</td>
                                    </tr>
                                </table></EmptyDataTemplate>
                    <ItemTemplate>
                  <tr>
                  <td><%# Eval("USERNAME") %>
                   </td>
                   
          <td>
             <%#Eval("APPLICATIONNAME") %>
            </td>
                   <td>
                  <%#Eval("MACHINENAME") %>
                   </td>
                   <td>
                    <%#Eval("CLASSNAME") %>
                   </td>
                   <td>
                  <%#Eval("MESSAGE") %>
                   </td>
                <td>
                <%#Eval("URL") %>
                </td>
                <td>
               <%# DateTimeAgo.GetFormatDate(Eval("LOGGINGTIME"))%>
                </td>
                 </tr>
                </ItemTemplate>
                  <LayoutTemplate>
                <table class="table table-responsive">
                    <thead>
                        <tr>
                            <th>UserName</th>
                            <th>Application Name</th>
                            <th>Machine Name</th>
                            <th>Page Name</th>
                            <th>Message</th>
                              <th>Url</th>
                              <th>Logging Time</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr id="itemPlaceholder" runat="server" />
                    </tbody>
                </table>
            </LayoutTemplate>
            </asp:ListView>
            <div class="box-footer clearfix">
                    <div class="pagination pagination-sm no-margin pull-right">
            <asp:DataPager ID="dpMessageLog" runat="server" PagedControlID="lv_MessageLog" PageSize="10" class="btn-group-sm pager-buttons">
                            <Fields>
                                <asp:NextPreviousPagerField ShowLastPageButton="False" ShowNextPageButton="False" ButtonType="Button" ButtonCssClass="btn btn-primary" RenderNonBreakingSpacesBetweenControls="false" />
                                <asp:NumericPagerField ButtonType="Button" RenderNonBreakingSpacesBetweenControls="false" NumericButtonCssClass="btn btn-primary" CurrentPageLabelCssClass="btn disabled" NextPreviousButtonCssClass="btn" />
                                <asp:NextPreviousPagerField ShowFirstPageButton="False" ShowPreviousPageButton="False" ButtonType="Button" ButtonCssClass="btn btn-primary" RenderNonBreakingSpacesBetweenControls="false" />
                            </Fields>
            </asp:DataPager>  
            </div>
            </div>
            </div>
            </div>
           </div>
    </asp:Content>
