using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace USGClient.MasterPages
{
    public partial class AdminPage1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var path = Request.RawUrl;
            String[] UserID = path.Split('=');
            if(UserID[1] == "1")
            {
                ShoppingSiteData.tblUser objUser = new ShoppingSiteData.tblUser(ShoppingSiteData.Conversion.ConvertToInt32(UserID[1]));
                lnkAdministrator.InnerHtml = objUser.name;
                admin.InnerHtml = objUser.name;
            }

            



            HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            HttpContext.Current.Response.Cache.SetNoStore();
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(60));
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            System.Web.Security.FormsAuthentication.SignOut();
            string host = HttpContext.Current.Request.Url.Host;  //Gets the hosted url .

            if (host == "localhost")
            {
                Response.Redirect("/Login.aspx");
            }
            //else
            //{
            //    Response.Redirect("https://www.usgfla.com/Client-Resources/Client-Portal", true);
            //}
        }

        //private Boolean ChangePassword()
        //{
        //    Boolean bReturn = false;

        //    Int32 nAdminID = USGData.Conversion.ConvertToInt32(Request.QueryString["ID"]);
        //    USGData.Administrator objClient = new USGData.Administrator(nAdminID);

        //    string DNNUserID = objClient.DNNUserID.ToString();

        //    var request = (HttpWebRequest)WebRequest.Create("http://usg.gonzosystems.net/Reset-Password");
        //    //var request = (HttpWebRequest)WebRequest.Create("http://localhost:38887/TestCreateUser.aspx");
        //    String strEncrypt = "";
        //    strEncrypt = DNNUserID;
        //    var postData = "postData=" + Encrypt(strEncrypt, "xav13r2417!Apple");
        //    var data = Encoding.ASCII.GetBytes(postData);

        //    request.Method = "POST";
        //    request.ContentType = "application/x-www-form-urlencoded";
        //    request.ContentLength = data.Length;

        //    using (var stream = request.GetRequestStream())
        //    {
        //        stream.Write(data, 0, data.Length);
        //    }

        //    var response = (HttpWebResponse)request.GetResponse();
        //    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

        //    return responseString.Substring(0, 12) == "User Created";
        //}
        public static string Encrypt(string input, string key)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

    }
}