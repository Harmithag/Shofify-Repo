using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingSite
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCards();
        }

        #region Methods
        private void LoadCards()

        {
            Int32 nUserID = ShoppingSiteData.Conversion.ConvertToInt32(Request.QueryString["UID"]);


            ShoppingSiteData.tblCardList objcard = new ShoppingSiteData.tblCardList();
            //DataView dv = objcard.GetList().DefaultView;
            //dv.RowFilter = "userId='" + nUserID + "'";
             DataView dv = objcard.GetCartList(nUserID).DefaultView;

            rptProduct.DataSource = dv;
            rptProduct.DataBind();

        }
        #endregion
        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            System.Web.Security.FormsAuthentication.SignOut();
            string host = HttpContext.Current.Request.Url.Host;  //Gets the hosted url .

            if (host == "localhost")
            {
                Response.Redirect("/Login.aspx");
            }
           
        }

        public String GetImage(Object objImage)
        {
            String strReturn = "";
            String strPDF = ShoppingSiteData.Conversion.ConvertToString(objImage).ToString();

            if (strPDF.Length > 0)
            {
                strReturn = "<img style='width:120px; height:120px' src=\"" + objImage + "\"" + ">";
            }

            return strReturn;
        }
        public int Getvalue(Object price, Object count)
        {
            int total = 0;
            int price1 = ShoppingSiteData.Conversion.ConvertToInt32(price);
            int count1= ShoppingSiteData.Conversion.ConvertToInt32(count);
             total = price1 * count1;
            return total;
        }

        [System.Web.Services.WebMethod]
        public static dynamic DeleteCard(string cardlistId)
        {
            ShoppingSiteData.tblCardList objUser = new ShoppingSiteData.tblCardList(ShoppingSiteData.Conversion.ConvertToInt32(cardlistId));


            if (objUser.Delete() == true)
            {
                return "Success";
            }
            else
            {
                return "Error";
            }

        }

    }
}