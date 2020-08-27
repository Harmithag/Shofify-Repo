using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingSite
{
    public partial class Registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        [System.Web.Services.WebMethod]
        public static dynamic CreateUser(string name, string phone,string email, string password)
        {
            ShoppingSiteData.tblUser objUser = new ShoppingSiteData.tblUser();
            objUser.name = name;
            objUser.email = email;
            objUser.phoneNumber = phone;
            objUser.password = password;
            objUser.role = "User";
            objUser.createdDate = DateTime.Now;
            objUser.isDeleted = false;


            if (objUser.Create() > 0)
            {
                return "Success";

            }
            else
            {
                return "Error";

            }

        }

        //protected void btnLogin_Click(object sender, EventArgs e)
        //{

        //    ShoppingSiteData.tblUser objUser = new ShoppingSiteData.tblUser();
        //    objUser.name = txtName.Text.Trim();
        //    objUser.email=txtEmail.Text.Trim();
        //    objUser.phoneNumber = txtPhoneNumber.Text.Trim();
        //    objUser.password = txtPassword.Text.Trim();
        //    objUser.role = "User";
        //    objUser.createdDate =DateTime.Now;
        //    objUser.isDeleted = false;

        //    if (objUser.Create() > 0)
        //    {
        //        Response.Redirect("Login.aspx");
        //    }
        //    else
        //    {
        //        lblMessage.ForeColor = System.Drawing.Color.Red;
        //        lblMessage.Text = "An error has occurred.  User was not added.";
        //    }


        //}
    }
}