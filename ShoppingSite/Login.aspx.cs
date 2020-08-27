using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingSite
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // lblError.Text = "";
        }


        [System.Web.Services.WebMethod]
        public static dynamic ValidateLogin(string email, string password)
        {
            ShoppingSiteData.tblUser objUser = new ShoppingSiteData.tblUser();

            DataView dv = objUser.GetList().DefaultView;

            dv.RowFilter = "email='" + email + "'";

            if (dv.Count > 0 & dv[0]["password"].ToString() == password)
            {
                Int32 nUserID = ShoppingSiteData.Conversion.ConvertToInt32(dv[0]["userId"]);

                var Name = dv[0]["name"].ToString();
                String strEmailAddress = dv[0]["email"].ToString();
                FormsAuthentication.SetAuthCookie(nUserID + "~" + "USER" + "~" + strEmailAddress, false);
                return nUserID;

                //Int32 nUserID = ShoppingSiteData.Conversion.ConvertToInt32(dv[0]["userId"]);

                //var Name = dv[0]["name"].ToString();
                //String strEmailAddress = dv[0]["email"].ToString();
               
                //    if (dv[0]["password"].ToString() == password)
                //    {
                //        return "Success";
                //        //Response.Redirect("Products?ID=1");
                //    }
                  
               
            }
            else
            {
                return "Error";
            }
           
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ShoppingSiteData.tblUser objUser = new ShoppingSiteData.tblUser();

            DataView dv = objUser.GetList().DefaultView;

            //dv.RowFilter = "email='" + txtEmailAddress.Text.Trim() + "'";
            //if (dv.Count > 0)
            //{
            //    Int32 nUserID = ShoppingSiteData.Conversion.ConvertToInt32(dv[0]["userId"]);

            //    var Name = dv[0]["name"].ToString();
            //    String strEmailAddress = dv[0]["email"].ToString();
            //    var FullName = Name;
            //    Session[Name] = FullName;

            //    if (nUserID > 0)
            //    {
            //        if (dv[0]["password"].ToString() == txtPassword.Text.Trim())
            //        {
            //            FormsAuthentication.SetAuthCookie(nUserID + "~" + "USER" + "~" + strEmailAddress, false);
            //            string page = Request.QueryString["p"];
            //            //Session["CurrentID"] = nUserID;
            //            //Session["CurrentUserID"] = nUserID;
            //            Response.Redirect("Products?ID=1");
            //            // Response.Redirect("ClientPortal/Default.aspx");
            //        }
            //        else
            //        {
            //            lblError.Text = "An error has occurred. Please check your login credentials and try again.";
            //        }
            //    }
            //}
        }
    }
}