using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace BKApp
{
    /// <summary>
    /// Summary description for ThongTinHocPhanSinhVienWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ThongTinHocPhanSinhVienWS : System.Web.Services.WebService
    {
        BKDBDataContext db = null;
        [WebMethod]
        public String GetThongTinHocPhanSinhVien(String masv)
        {
            db = new BKDBDataContext();
            ThongTinHocPhanSinhVienWSI wsi = null;

            SinhVien sinhVien = new SinhVien();
            List<getSinhVienByMasvResult> sinhVienResult = db.getSinhVienByMasv(masv).ToList();
            if (sinhVienResult != null && sinhVienResult.Count > 0)
            {
                wsi = new ThongTinHocPhanSinhVienWSI();
                sinhVien.Masv = sinhVienResult.First().Masv;
                sinhVien.Maph = sinhVienResult.First().Maph;
                sinhVien.Macs = sinhVienResult.First().Macs;
                sinhVien.Malsh = sinhVienResult.First().Malsh;
                sinhVien.Tensv = sinhVienResult.First().Tensv;
                sinhVien.Sodt = sinhVienResult.First().Sodt;
                sinhVien.Email = sinhVienResult.First().Email;
                sinhVien.Ngaysinh = sinhVienResult.First().Ngaysinh;
                sinhVien.Noisinh = sinhVienResult.First().Noisinh;
                sinhVien.Noithuongtru = sinhVienResult.First().Noithuongtru;
                sinhVien.Gioitinh = sinhVienResult.First().Gioitinh;
                sinhVien.Dantoc = sinhVienResult.First().Dantoc;
                sinhVien.Tongiao = sinhVienResult.First().Tongiao;
                sinhVien.Socmnd = sinhVienResult.First().Socmnd;
                sinhVien.DeleteDate = sinhVienResult.First().DeleteDate;
                sinhVien.DeleteUserId = sinhVienResult.First().DeleteUserId;

                List<getLopHocPhanByMasvResult> listHocPhanResult = db.getLopHocPhanByMasv(sinhVien.Masv).ToList();
                List<LopHocPhanSinhVien> listHocPhanSinhVien = null;
                List<LopHocPhan> listLopHocPhan = null;
                List<HocPhan> listHocPhan = null;
                List<ChiTietLopHocPhan> listChiTietLopHocPhan = null;
                if (listHocPhanResult != null && listHocPhanResult.Count > 0)
                {
                    listHocPhanSinhVien = new List<LopHocPhanSinhVien>();
                    listLopHocPhan = new List<LopHocPhan>();
                    listHocPhan = new List<HocPhan>();
                    listChiTietLopHocPhan = new List<ChiTietLopHocPhan>();

                    foreach (var item in listHocPhanResult)
                    {
                        LopHocPhanSinhVien lhpsv = new LopHocPhanSinhVien();
                        lhpsv.Id = item.Id;
                        lhpsv.Masv = item.Masv;
                        lhpsv.Malhp = item.Malhp;
                        lhpsv.Dtkck = item.Dtkck;
                        lhpsv.Dtkgk = item.Dtkgk;
                        lhpsv.Dtkhp = item.Dtkhp;
                        lhpsv.Dcc = item.Dcc;
                        lhpsv.Tichluy = item.Tichluy;
                        lhpsv.Ghichu = item.Ghichu;
                        lhpsv.DeleteDate = item.DeleteDate;
                        lhpsv.DeleteUserId = item.DeleteUserId;
                        listHocPhanSinhVien.Add(lhpsv);

                        LopHocPhan lhp = new LopHocPhan();
                        lhp.Malhp = item.Malhp;
                        lhp.Mahp = item.Mahp;
                        lhp.Macbgv = item.Macbgv;
                        lhp.Mahk = item.Mahk;
                        lhp.Soluong = item.Soluong;
                        lhp.Soluongdk = item.Soluongdk;
                        lhp.Ngaybatdau = item.Ngaybatdau;
                        lhp.Ngaynopdiem = item.Ngaynopdiem;
                        lhp.Ngaythi = item.Ngaythi;
                        lhp.Giothi = item.Giothi;
                        lhp.Ngaynopdiem = item.Ngaynopdiem;
                        lhp.Ghichu = item.Ghichu;
                        lhp.DeleteDate = item.DeleteDate1;
                        lhp.DeleteUserId = item.DeleteUserId1;
                        listLopHocPhan.Add(lhp);

                        HocPhan hp = new HocPhan();
                        hp.Mahp = item.Mahp;
                        hp.Tenhp = item.Tenhp;
                        hp.Mota = item.Mota;
                        hp.Sotc = item.Sotc;
                        hp.Lythuyet = item.Lythuyet;
                        hp.Thuchanhbt = item.Thuchanhbt;
                        hp.Doan = item.Doan;
                        hp.Ghichu = item.Ghichu2;
                        hp.DeleteDate = item.DeleteDate2;
                        hp.DeleteUserId = item.DeleteUserId2;
                        listHocPhan.Add(hp);

                        List<getChiTietLopHocPhanByMalhpResult> listChiTietLopHocPhanResult = db.getChiTietLopHocPhanByMalhp(lhp.Malhp).ToList();
                        if (listChiTietLopHocPhanResult != null && listChiTietLopHocPhanResult.Count > 0)
                        {
                            foreach(var temp in listChiTietLopHocPhanResult)
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
                    }

                }
                wsi.SinhVien = sinhVien;
                wsi.LopHocPhans = listLopHocPhan;
                wsi.LopHocPhanSinhViens = listHocPhanSinhVien;
                wsi.HocPhans = listHocPhan;
                wsi.ChiTietLopHocPhan = listChiTietLopHocPhan;
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            string str = js.Serialize(wsi);
            return str;
        }
    }
}
