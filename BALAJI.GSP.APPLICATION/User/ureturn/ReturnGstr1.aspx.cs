﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//new
using DataAccessLayer;
using GST.Utility;
using BusinessLogic.Repositories;

namespace BALAJI.GSP.APPLICATION.User.ureturn
{
    public partial class ReturnGstr1 : System.Web.UI.Page
    {
        UnitOfWork unitOfwork = new UnitOfWork();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Request.Cookies["PreviousPage"] != null)
                    Response.Write(Request.Cookies["PreviousPage"].Value);
                BindFinyear();
                // BindInvoiceMonth();

                if (Session["Month"] != null)
                {
                    var month = Session["Month"].ToString();
                }

            }

            uc_Gstr_Tileview.Info_Click += uc_Gstr_Tileview_Info_Click; //AddMoreClick += uc_B2B_Invoices_AddMoreClick;
            uc_invoiceMonth.SelectedIndexChange += uc_invoiceMonth_SelectIndexChange;
            uc_GSTNUsers.addInvoiceRedirect += uc_GSTNUsers_addInvoiceRedirect;
            uc_GSTNUsers.addInvoicechkRedirect += uc_GSTNUsers_addInvoicechkRedirect;
        }
        int MonthName;
        private void uc_GSTNUsers_addInvoicechkRedirect(object sender, EventArgs e)
        {
            var ddlvalue = uc_GSTNUsers.ddlGSTNUsers.SelectedIndex;
            var chkvalue = uc_GSTNUsers.GetchkValue;
            // var ddlenable = uc_GSTNUsers.ddlGSTNUsers.Enabled = false;
            if (ddlvalue == 0)
            {
                //ddlenable = false;
                var loggedInUser = Common.LoggedInUserID();
                //for turnover start
                //Label mpLabel = (Label)uc_GSTR_Taxpayer.FindControl("lblTurnoverAMT");
                int Monthpageload = Convert.ToByte(DateTime.Now.Month - 1);
                List<string> userLists = new List<string>();
                if (uc_GSTNUsers.AssociatedUsersIds != null)
                {
                    userLists = uc_GSTNUsers.AssociatedUsersIds;//TODO:Repetation remove need to work here again asap by ankita
                }
                userLists.Add(loggedInUser);
                //mpLabel.Text = unitOfwork.InvoiceDataRepository.Filter(f => f.GST_TRN_INVOICE.InvoiceMonth == Monthpageload && userLists.Contains(f.GST_TRN_INVOICE.InvoiceUserID)).Sum(s => s.TaxableAmount).ToString();

                //End

              //  BindAllList(loggedInUser, DateTime.Now.Month - 1);
              //  uc_invoiceMonth.BindInvoiceMonth();
            }
        }

        private void uc_GSTNUsers_addInvoiceRedirect(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;
            uc_GSTNUsers.ddlGSTNUsers.SelectedValue = ddl.SelectedValue;

            var taxuserid = uc_GSTNUsers.ddlGSTNUsers.SelectedValue;
            Session["taxid"] = taxuserid;
            //var taxConsultantId = Session["taxid"];
        }



        private void uc_invoiceMonth_SelectIndexChange(object sender, EventArgs e)
        {
            // int Monthnew = Convert.ToInt32(uc_invoiceMonth.GetIndexValue);
            var month = uc_invoiceMonth.GetIndexValue;
            Session["Month"] = month;
        }

        private void uc_Gstr_Tileview_Info_Click(object sender, EventArgs e)
        {
            //var year =Convert.ToInt16( ddlfinYear.SelectedValue);
            //// var month = Convert.ToByte(ddlmonth.SelectedValue);
            //var month =Convert.ToInt16( uc_invoiceMonth.GetIndexValue);
            //Session["Month"] = month;
            //var a = (byte);
            ////var b = (byte)EnumConstants.Return.Gstr2A;
            ////var c = (byte)EnumConstants.Return.Gstr3B;

            //var status = uc_Gstr_Tileview.ReturenHeaderStatus(year, month);

            ////var ReturnStatus = ;// .Select(s => s.ReturnStatus); // unitOfwork.ReturnStatusRepository.Filter(f => f.ReturnStatus ==Status.Contains).Select(s => s.ReturnStatus);

            //if (status.Where(w => w.ReturnStatus == a).SingleOrDefault().ReturnStatus==a)
            //{
            //    Response.Redirect("~/User/ureturn/GSTR1Details.aspx");
            //}
            //else if (status.Where(w => w.ReturnStatus == b).SingleOrDefault().ReturnStatus == b)
            //{

            //}
            //else
            //{
            //    Response.Redirect("~/User/ureturn/GSTR3BDetails.aspx");
            //}
            // var invoiceAudit = unitOfwork.InvoiceAuditTrailRepositry.Filter(f => f.AuditTrailStatus == 0 && ).OrderByDescending(o => o.InvoiceDate).ToList();
            //var invoiceList = unitOfwork.InvoiceRepository.Filter(f => f.InvoiceMonth == month && f.Status == true).OrderByDescending(o => o.InvoiceDate).ToList();

            //amits for gstr 3b condition 
          
        }

        protected void ddlfinYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Year"] = Convert.ToInt16(this.ddlfinYear.SelectedItem.Value);

        }
        public void BindFinyear()
        {
            try
            {
                ddlfinYear.DataSource = unitOfwork.FinYearRepository.All().OrderBy(o => o.Finyear).ToList();
                ddlfinYear.DataTextField = "Finyear_Format";
                ddlfinYear.DataValueField = "Fin_ID";
                ddlfinYear.DataBind();
                ddlfinYear.Items.Insert(0, new ListItem(" [ SELECT ] ", "0"));
                string Year = DateTime.Now.Year.ToString() + "-" + (DateTime.Now.Year + 1).ToString().Substring((DateTime.Now.Year + 1).ToString().Length - 2);
                ddlfinYear.Items.FindByText(Year).Selected = true;
            }
            catch (Exception ex)
            {
                cls_ErrorLog ob = new cls_ErrorLog();
                cls_ErrorLog.LogError(ex, Common.LoggedInUserID());
            }
        }


        ////Bind Month
        //public void BindInvoiceMonth()
        //{
        //    try
        //    {
        //        Array Months = Enum.GetValues(typeof(EnumConstants.FinYear));
        //        ddlmonth.Items.Clear();
        //        ddlmonth.Items.Insert(0, new ListItem(" [ SELECT ] ", "0"));
        //        foreach (EnumConstants.FinYear month in Months)
        //        {
        //            ddlmonth.Items.Add(new ListItem(month.ToString(), ((byte)month).ToString()));
        //        }
        //        ddlmonth.SelectedValue = (DateTime.Now.Month - 1).ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        cls_ErrorLog ob = new cls_ErrorLog();
        //        cls_ErrorLog.LogError(ex, Common.LoggedInUserID());
        //    }
        //}

        //private List<GST_TRN_RETURN_STATUS> GetFilterInvoiceReturn(int Year, int SelectedMonth)
        //{
        //    unitOfwork = new UnitOfWork();
        //    List<GST_TRN_RETURN_STATUS> invoiceList = new List<GST_TRN_RETURN_STATUS>();
        //    var loggedinUser = Common.LoggedInUserID();
        //    var return1 = (byte)EnumConstants.Return.Gstr1;
        //    var return2 = (byte)EnumConstants.Return.Gstr3B;
        //    var invstatusfile = (byte)EnumConstants.ReturnFileStatus.FileGstr1;
        //    var invstatussave = (byte)EnumConstants.ReturnFileStatus.Save;
        //    var invstatussubmit = (byte)EnumConstants.ReturnFileStatus.Submit;
        //    //var FindMax = unitOfwork.ReturnStatusRepository.Filter(f => f.ReturnStatus = return1).Max(a => a.Action);
        //    var FindMax = unitOfwork.ReturnStatusRepository.All().Max(a => a.Action);
        //    invoiceList = unitOfwork.ReturnStatusRepository.Filter(f => f.User_id == loggedinUser && f.Period == SelectedMonth && f.Status == 1 && f.Action == 2).ToList();
        //    return invoiceList;
        //}


        //private List<GST_TRN_INVOICE> GetFilterInvoice(int Year, int SelectedMonth)
        //{
        //    unitOfwork = new UnitOfWork();
        //    List<GST_TRN_INVOICE> invoiceList = new List<GST_TRN_INVOICE>();
        //    var loggedinUser = Common.LoggedInUserID();

        //    invoiceList = unitOfwork.InvoiceRepository.Filter(f => f.InvoiceUserID == loggedinUser && f.InvoiceMonth == SelectedMonth).ToList();
        //    return invoiceList;
        //}
        public int GetFilterInvoice(int Year, int SelectedMonth,string UserId)
        {
            unitOfwork = new UnitOfWork();
            var loggedinUser = Common.LoggedInUserID();

            uc_Gstr_Tileview.ReturenHeaderStatus(Year, SelectedMonth, UserId);

            //if (uc_GSTNUsers.ddlGSTNUsers.SelectedIndex > 0)
            //{
            //    var taxi = Session["taxid"].ToString();
            //    var FindMax = unitOfwork.ReturnStatusRepository.Filter(f => f.Period == SelectedMonth && f.FinYear_ID == Year).Max(a => a.Action);
            //    // invoiceList = unitOfwork.ReturnStatusRepository.Filter(f => f.User_id == taxi && f.Period == SelectedMonth && f.FinYear_ID == Year && f.Action == FindMax).ToList();
            //    //invoices = unitOfwork.headerrepository.All().ToList();


            //}
            //else
            //{
            //    var FindMax = unitOfwork.ReturnStatusRepository.Filter(f => f.Period == SelectedMonth && f.FinYear_ID == Year).Max(a => a.Action);
            //    //invoiceList = unitOfwork.ReturnStatusRepository.Filter(f => f.User_id == loggedinUser && f.Period == SelectedMonth && f.FinYear_ID == Year && f.Action == FindMax).ToList();
            //    //invoices = unitOfwork.headerrepository.All().ToList();

            //}
            return 0;
        }


        private void PopulateTileViewInvoices(int Year, int SelectedMonth, int Status)
        {
            var taxConsultantId = Session["taxid"];
            var loggedInUser = Common.LoggedInUserID();
            var ddlmonth = uc_invoiceMonth.GetIndexValue;
            var ddlyear = ddlfinYear.SelectedValue;
            var invstatusfile = EnumConstants.ReturnFileStatus.FileGstr1;
            var invstatussave = EnumConstants.ReturnFileStatus.Save;
            var invstatussubmit = (byte)EnumConstants.ReturnFileStatus.Submit;


            if (uc_GSTNUsers.ddlGSTNUsers.SelectedIndex > 0)
            {
                var invoicesB2B = GetFilterInvoice(Convert.ToInt16(ddlyear), Convert.ToInt16(ddlmonth), Convert.ToString(taxConsultantId));
                var dataB2b = invoicesB2B;
            }
            else 
            {
                var invoicesB2B = GetFilterInvoice(Convert.ToInt16(ddlyear), Convert.ToInt16(ddlmonth), Convert.ToString(loggedInUser));
                var dataB2b = invoicesB2B;
            }
            //uc_Gstr_Tileview.InvoiceList = dataB2b;

            //if (Status == invstatusfile || Status == invstatussave || Status == invstatussubmit)
            //{
            //    var invoicesB2BA = GetFilterInvoiceReturn(Convert.ToInt16(ddlyear), Convert.ToInt16(ddlmonth));
            //    var dataB2bA = invoicesB2BA;
            //    //uc_Gstr_Tileview.InvoiceList = dataB2bA;
            //}
            //else 
            //{ 
            //    var invoicesB2B = GetFilterInvoice(Convert.ToInt16(ddlyear), Convert.ToInt16(ddlmonth));
            //    var dataB2bc = invoicesB2B;
            //    uc_Gstr_Tileview.InvoiceList = dataB2bc;
            //}




        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            var year = ddlfinYear.SelectedValue;
            var month = uc_invoiceMonth.GetIndexValue;
            var CurrentMonth = DateTime.Now.Month;
            if (month != CurrentMonth)
            {
                // uc_Gstr_Tileview.Re.Visible = true;
                PopulateTileViewInvoices(Convert.ToInt16(year), Convert.ToInt16(month), 3);
            }
        }
    }
}