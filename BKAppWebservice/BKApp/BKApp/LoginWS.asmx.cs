using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace BKApp
{
    /// <summary>
    /// Summary description for LoginWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LoginWS : System.Web.Services.WebService
    {
        BKDBDataContext db = null;
        [WebMethod]
        public String Login(String masv, String password)
        {
            db = new BKDBDataContext();
            LoginUser loginUser = new LoginUser();
            List<CheckLoginResult> result = db.CheckLogin(masv, password).ToList();
            if (result != null && result.Count > 0)
            {
                loginUser.LoginUserId = result[0].LoginUserId;
                loginUser.Password = result[0].Password;
                loginUser.InsertDate = result[0].InsertDate;
                loginUser.UpdateDate = result[0].UpdateDate;
                loginUser.NewPassword = result[0].NewPassword;
                loginUser.Macv = result[0].Macv;
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            string str = js.Serialize(loginUser);
            return str;
        }
    }
}
