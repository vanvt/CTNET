using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
namespace JVL
{
    /// <summary>
    /// Summary description for ThongTinSinhVienWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]
    public class ThongTinSinhVienWS : System.Web.Services.WebService
    {
        [WebMethod]
        public ThongTinSinhVienWSI CallService(ThongTinSinhVienWSI wsi)
        {
            ThongTinSinhVienBL BL = new ThongTinSinhVienBL();
            //ThongTinSinhVienCL CL = new ThongTinSinhVienCL();
            //wsi = CL.CallCheckLogic(wsi);
            //if (!String.IsNullOrEmpty(wsi.IsWsiError))
            //{
            //    return wsi;
            //}
            wsi = BL.CallBussinessLogic(wsi);
            return wsi;
        }
    }
}
