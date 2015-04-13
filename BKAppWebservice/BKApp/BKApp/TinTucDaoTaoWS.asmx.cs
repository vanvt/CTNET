using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace BKApp
{
    /// <summary>
    /// Summary description for TinTucDaoTaoWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TinTucDaoTaoWS : System.Web.Services.WebService
    {
        BKDBDataContext db = null;
        [WebMethod]
        public String GetTinTucDaoTao()
        {
            db = new BKDBDataContext();
            List<GetTinTucPublicResult> result = db.GetTinTucPublic().ToList();
            List<TinTucDaoTao> listTinTuc = null;
            List<TheLoaiTin> listTheLoaiTin = null;
            List<CanBoGiaoVien> listCanBoGiaoVien = null;
            TinTucDaoTao tintucdaotao = null;
            TinTucDaoTaoWSI wsi = null;
            if (result.Count > 0)
            {
                listTinTuc = new List<TinTucDaoTao>();
                listTheLoaiTin = new List<TheLoaiTin>();
                listCanBoGiaoVien = new List<CanBoGiaoVien>();
                foreach (var item in result)
                {
                    tintucdaotao = new TinTucDaoTao();
                    tintucdaotao.Id = item.Id;
                    tintucdaotao.Macbgv = item.Macbgv;
                    tintucdaotao.Matlt = item.Matlt;
                    tintucdaotao.Hinhanh = item.Hinhanh;
                    tintucdaotao.Filedinhkem = item.Filedinhkem;
                    tintucdaotao.DeleteDate = item.DeleteDate;
                    tintucdaotao.DeleteUserId = item.DeleteUserId;
                    tintucdaotao.Thoigian = item.Thoigian;
                    tintucdaotao.Tieude = item.Tieude;
                    tintucdaotao.Tomtat = item.Tomtat;
                    tintucdaotao.Noidung = item.Noidung;
                    listTinTuc.Add(tintucdaotao);

                    TheLoaiTin tlt = new TheLoaiTin();
                    getTheLoaiTinByMatltResult tempresult = db.getTheLoaiTinByMatlt(item.Matlt).First();
                    tlt.Matlt = tempresult.Matlt;
                    tlt.Tentlt = tempresult.Tentlt;
                    listTheLoaiTin.Add(tlt);

                    CanBoGiaoVien cbgv = new CanBoGiaoVien();
                    getCanBoGiaoVienByMacbgvResult cbgvresult = db.getCanBoGiaoVienByMacbgv(item.Macbgv).First();
                    cbgv.Macbgv = cbgvresult.Macbgv;
                    cbgv.Ngaysinh = cbgvresult.Ngaysinh;
                    cbgv.Gioitinh = cbgvresult.Gioitinh;
                    cbgv.Tencbgv = cbgvresult.Tencbgv;
                    cbgv.Socmnd = cbgvresult.Socmnd;
                    cbgv.Sodt = cbgvresult.Sodt;
                    cbgv.Email = cbgvresult.Email;
                    cbgv.DeleteDate = cbgvresult.DeleteDate;
                    cbgv.DeleteUserId = cbgvresult.DeleteUserId;
                    cbgv.Dantoc = cbgvresult.Dantoc;
                    cbgv.Noithuongtru = cbgvresult.Noithuongtru;
                    cbgv.Noisinh = cbgvresult.Noisinh;
                    listCanBoGiaoVien.Add(cbgv);
                }
                wsi = new TinTucDaoTaoWSI();
                wsi.TinTucDaoTao = listTinTuc;
                wsi.CanBoGiaoVien = listCanBoGiaoVien;
                wsi.TheLoaiTin = listTheLoaiTin;
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            string str = js.Serialize(wsi);
            return str;
        }
    }
}
