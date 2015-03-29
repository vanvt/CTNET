using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
namespace JVL
{
    /// <summary>
    /// Summary description for TinTucDaoTaoWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]
    public class TinTucDaoTaoWS : System.Web.Services.WebService
    {
        [WebMethod]
        public TinTucDaoTaoWSI CallService(TinTucDaoTaoWSI wsi)
        {
            TinTucDaoTaoBL BL = new TinTucDaoTaoBL();
            //TinTucDaoTaoCL CL = new TinTucDaoTaoCL();
            //wsi = CL.CallCheckLogic(wsi);
            //if (!String.IsNullOrEmpty(wsi.IsWsiError))
            //{
            //    return wsi;
            //}
            wsi = BL.CallBussinessLogic(wsi);
            return wsi;
        }
        [WebMethod]
        public String CallServiceWithJson(String jsonWsi)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            TinTucDaoTaoWSI wsi = new TinTucDaoTaoWSI();
            wsi = js.Deserialize<TinTucDaoTaoWSI>(jsonWsi);
            TinTucDaoTaoBL BL = new TinTucDaoTaoBL();
            wsi = BL.CallBussinessLogic(wsi);
            string str = js.Serialize(wsi);
            return str;
        }
    }
}
