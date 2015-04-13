using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace BKApp
{
    /// <summary>
    /// Summary description for LopHocPhanDKWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LopHocPhanDKWS : System.Web.Services.WebService
    {
        BKDBDataContext db = null;

        [WebMethod]
        public String getLopHocPhanDKByMasv(string masv)
        {
            LopHocPhanDKWSI wsi = null;
            db = new BKDBDataContext();
            List<getListLopHocPhanDKByMasvResult> result = db.getListLopHocPhanDKByMasv(masv).ToList();
            if (result != null && result.Count > 0)
            {
                wsi = new LopHocPhanDKWSI();
                List<LopHocPhan> listLopHocPhan = new List<LopHocPhan>();
                List<HocKy> listHocKy = new List<HocKy>();
                List<ChiTietLopHocPhan> listChiTietLopHocPhan = new List<ChiTietLopHocPhan>();
                List<CanBoGiaoVien> listCanBoGiaoVien = new List<CanBoGiaoVien>();
                List<HocPhan> listHocPhan = new List<HocPhan>();

                for (int i = 0; i < result.Count; i++)
                {
                    LopHocPhan lhp = new LopHocPhan();
                    lhp.Malhp = result[i].Malhp;
                    lhp.Mahp = result[i].Mahp;
                    lhp.Macbgv = result[i].Macbgv;
                    lhp.Mahk = result[i].Mahk;
                    lhp.Soluong = result[i].Soluong;
                    lhp.Soluongdk = result[i].Soluongdk;
                    lhp.Ngaybatdau = result[i].Ngaybatdau;
                    lhp.Ngaythi = result[i].Ngaythi;
                    lhp.Ngaynopdiem = result[i].Ngaynopdiem;
                    lhp.Giothi = result[i].Giothi;
                    lhp.DeleteDate = result[i].DeleteDate;
                    lhp.DeleteUserId = result[i].DeleteUserId;
                    listLopHocPhan.Add(lhp);

                    HocPhan hp = new HocPhan();
                    hp.Mahp = result[i].Mahp;
                    hp.Tenhp = result[i].Tenhp;
                    hp.Mota = result[i].Mota;
                    hp.Sotc = result[i].Sotc;
                    hp.Lythuyet = result[i].Lythuyet;
                    hp.Thuchanhbt = result[i].Thuchanhbt;
                    hp.Doan = result[i].Doan;
                    hp.Ghichu = result[i].Ghichu1;
                    hp.DeleteDate = result[i].DeleteDate1;
                    hp.DeleteUserId = result[i].DeleteUserId1;
                    listHocPhan.Add(hp);

                    List<getChiTietLopHocPhanByMalhpResult> listChiTietLopHocPhanResult = db.getChiTietLopHocPhanByMalhp(lhp.Malhp).ToList();
                    if (listChiTietLopHocPhanResult != null && listChiTietLopHocPhanResult.Count > 0)
                    {
                        foreach (var temp in listChiTietLopHocPhanResult)
                        {
                            ChiTietLopHocPhan ctlhp = new ChiTietLopHocPhan();
                            ctlhp.Id = temp.Id;
                            ctlhp.Malhp = temp.Malhp;
                            ctlhp.Thu = temp.Thu;
                            ctlhp.Tutiet = temp.Tutiet;
                            ctlhp.Dentiet = temp.Dentiet;
                            ctlhp.Phong = temp.Phong;
                            ctlhp.DeleteDate = temp.DeleteDate;
                            ctlhp.DeleteUserId = temp.DeleteUserId;
                            listChiTietLopHocPhan.Add(ctlhp);
                        }
                    }

                    CanBoGiaoVien cbgv = new CanBoGiaoVien();
                    cbgv.Macbgv = result[i].Macbgv;
                    cbgv.Ngaysinh = result[i].Ngaysinh;
                    cbgv.Gioitinh = result[i].Gioitinh;
                    cbgv.Tencbgv = result[i].Tencbgv;
                    cbgv.Socmnd = result[i].Socmnd;
                    cbgv.Sodt = result[i].Sodt;
                    cbgv.Email = result[i].Email;
                    cbgv.DeleteDate = result[i].DeleteDate2;
                    cbgv.DeleteUserId = result[i].DeleteUserId2;
                    cbgv.Dantoc = result[i].Dantoc;
                    cbgv.Noithuongtru = result[i].Noithuongtru;
                    cbgv.Noisinh = result[i].Noisinh;
                    listCanBoGiaoVien.Add(cbgv);

                    HocKy hk = new HocKy();
                    hk.Mahk = result[i].Mahk;
                    hk.Tenhk = result[i].Tenhk;
                    listHocKy.Add(hk);
                }
                wsi.LopHocPhans = listLopHocPhan;
                wsi.ChiTietLopHocPhans = listChiTietLopHocPhan;
                wsi.CanBoGiaoViens = listCanBoGiaoVien;
                wsi.HocKys = listHocKy;
                wsi.HocPhans = listHocPhan;
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            String str = js.Serialize(wsi);
            return str;
        }

        [WebMethod]
        public bool DangKiHocPhan(String masv, String malhp)
        {
            db = new BKDBDataContext();
            try
            {
                if (db.DangKiLopHp(masv, malhp) == 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
