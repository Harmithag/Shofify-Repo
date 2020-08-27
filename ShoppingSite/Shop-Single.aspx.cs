using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingSite
{
    public partial class Shop_Single : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 nproductID = ShoppingSiteData.Conversion.ConvertToInt32(Request.QueryString["ID"]);


            LoadProduct(nproductID);
        }

        #region Methods
        private void LoadProduct(int productID)

        {

            ShoppingSiteData.tblProduct objProduct = new ShoppingSiteData.tblProduct();

           DataView dv = objProduct.GetList().DefaultView;
            dv.RowFilter = "productId='" + productID + "'";

            rptProduct.DataSource = dv;
            rptProduct.DataBind();



        }
        #endregion

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

        [System.Web.Services.WebMethod]
        public static dynamic AddCard(string productId, string count, string userId)
        {


            ShoppingSiteData.tblCardList objCard= new ShoppingSiteData.tblCardList();
            objCard.userId = ShoppingSiteData.Conversion.ConvertToInt32(userId); 
            objCard.productid = ShoppingSiteData.Conversion.ConvertToInt32(productId);
            objCard.count = ShoppingSiteData.Conversion.ConvertToInt32(count);
            objCard.status = "NotDelivered";
            


            if (objCard.Create() > 0)
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