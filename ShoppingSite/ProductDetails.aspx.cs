using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingSite
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public String GetImage(Object objImage)
        {
            String strReturn = "";
            String strPDF = ShoppingSiteData.Conversion.ConvertToString(objImage).ToString();

            if (strPDF.Length > 0)
            {
                //if (objMockup.MockupID < USGData.Conversion.ConvertToInt32(ConfigurationManager.AppSettings["CUTOFFID"]))
                //{
                strReturn = "<img style='width:100px; height:100px' src=\"" + objImage + "\"" + ">";
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