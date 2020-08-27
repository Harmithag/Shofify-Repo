using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingSite
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        #region Methods
        private void LoadProducts()

        {
            Int32 ncategoryID = ShoppingSiteData.Conversion.ConvertToInt32(Request.QueryString["ID"]);

            ShoppingSiteData.tblProduct objProduct = new ShoppingSiteData.tblProduct();
          
            DataView dv = objProduct.GetList().DefaultView;
            dv.RowFilter = "categoryId='" + ncategoryID + "'";
            rptProductList.DataSource = dv;
            rptProductList.DataBind();



        }
        #endregion

        public String GetImage(Object objImage)
        {
            String strReturn = "";
            String strPDF = ShoppingSiteData.Conversion.ConvertToString(objImage).ToString();

            if (strPDF.Length > 0)
            {
                //if (objMockup.MockupID < USGData.Conversion.ConvertToInt32(ConfigurationManager.AppSettings["CUTOFFID"]))
                //{
                strReturn = "<img style='width:120px; height:120px' src=\"" + objImage + "\"" + ">";

                //strReturn = "<a href=\"" + objImage + "\"" + "><img style='width:100px; height:100px' src=\"" + objImage + "\"" + "></a>";
                //}
                //else
                //{
                //    strReturn = "<a target=\"" + "_blank\"" + " href=\"" + ConfigurationManager.AppSettings["IMAGEBASEURL"] + objMockup.PromoMonth.ToString() + "_" + objMockup.PromoYear.ToString() + "/" + strPDF + "\"" + "><img src=\"" + ConfigurationManager.AppSettings["IMAGEBASEURL"] + objMockup.PromoMonth.ToString() + "_" + objMockup.PromoYear.ToString() + "/Thumbs/" + strPDF + "\"></a>";

                //}
            }

            return strReturn;
        }

    }
}