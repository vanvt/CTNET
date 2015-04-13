using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace BKApp
{
    /// <summary>
    /// Summary description for ThongTinSinhVienWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ThongTinSinhVienWS : System.Web.Services.WebService
    {
        BKDBDataContext db = null;
        [WebMethod]
        public String getThongTinSinhVien(String masv)
        {
            ThongTinSinhVienWSI wsi = null;
            db = new BKDBDataContext();
            List<getThongTinSinhVienByMasvResult> sinhVienResult = db.getThongTinSinhVienByMasv(masv).ToList();
            if (sinhVienResult != null && sinhVienResult.Count > 0)
            {
                wsi = new ThongTinSinhVienWSI();
                SinhVien sinhVien = new SinhVien();
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

                PhuHuynh phuHuynh = new PhuHuynh();
                phuHuynh.Maph = sinhVienResult.First().Maph1;
                phuHuynh.Hotencha = sinhVienResult.First().Hotencha;
                phuHuynh.Nghenghiepcha = sinhVienResult.First().Nghenghiepcha;
                phuHuynh.Hotenme = sinhVienResult.First().Hotenme;
                phuHuynh.Nghenghiepme = sinhVienResult.First().Nghenghiepme;
                phuHuynh.Diachi = sinhVienResult.First().Diachi;
                phuHuynh.Email = sinhVienResult.First().Email;
                phuHuynh.Sodienthoai = sinhVienResult.First().Sodienthoai;
                phuHuynh.DeleteDate = sinhVienResult.First().DeleteDate1;
                phuHuynh.DeleteUserId = sinhVienResult.First().DeleteUserId1;

                LopSinhHoat lopsinhhoat = new LopSinhHoat();
                lopsinhhoat.Malsh = sinhVienResult.First().Malsh;
                lopsinhhoat.Manganh = sinhVienResult.First().Manganh;
                lopsinhhoat.Macbgv = sinhVienResult.First().Macbgv;
                lopsinhhoat.Tenlsh = sinhVienResult.First().Tenlsh;
                lopsinhhoat.Siso = sinhVienResult.First().Siso;
                lopsinhhoat.Khoa = sinhVienResult.First().Khoa;
                lopsinhhoat.DeleteDate = sinhVienResult.First().DeleteDate2;
                lopsinhhoat.DeleteUserId = sinhVienResult.First().DeleteUserId2;

                Khoa khoa = new Khoa();
                khoa.Makhoa = sinhVienResult.First().Makhoa1;
                khoa.Tenkhoa = sinhVienResult.First().Tenkhoa;

                Nganh nganh = new Nganh();
                nganh.Manganh = sinhVienResult.First().Manganh1;
                nganh.Tennganh = sinhVienResult.First().Tennganh;
                nganh.Sotcbb = sinhVienResult.First().Sotcbb;
                nganh.Sotcdc = sinhVienResult.First().Sotcdc;
                nganh.Sotctc = sinhVienResult.First().Sotctc;
                nganh.MoTa = sinhVienResult.First().MoTa;
                nganh.Makhoa = sinhVienResult.First().Makhoa1;

                ChinhSach chinhsach = new ChinhSach();
                chinhsach.Macs = sinhVienResult.First().Macs1;
                chinhsach.Tencs = sinhVienResult.First().Tencs;

                List<TinTucSinhVien> listTinTuc = null;
                List<getTinTucSinhVienByMasvResult> tinTucSinhVienResult = db.getTinTucSinhVienByMasv(sinhVien.Masv).ToList();
                if (tinTucSinhVienResult != null && tinTucSinhVienResult.Count > 0)
                {
                    listTinTuc = new List<TinTucSinhVien>();
                    foreach (var item in tinTucSinhVienResult)
                    {
                        TinTucSinhVien ttsv = new TinTucSinhVien();
                        ttsv.Id = item.Id;
                        ttsv.Masv = item.Masv;
                        ttsv.Noidung = item.Noidung;
                        ttsv.Tieude = item.Tieude;
                        ttsv.Tomtat = item.Tomtat;
                        ttsv.Filedinhkem = item.Filedinhkem;
                        ttsv.Thoigian = item.Thoigian;
                        ttsv.Hinhanh = item.Hinhanh;
                        ttsv.DeleteDate = item.DeleteDate;
                        ttsv.DeleteUserId = item.DeleteUserId;
                        listTinTuc.Add(ttsv);
                    }
                }

                List<TheoDoiHocKy> listTheoDoiHocKy = null;
                List<getTheoDoiHocKyByMasvResult> listTheoDoiHocKyResult = db.getTheoDoiHocKyByMasv(sinhVien.Masv).ToList();
                if (listTheoDoiHocKyResult != null && listTheoDoiHocKyResult.Count > 0)
                {
                    listTheoDoiHocKy = new List<TheoDoiHocKy>();
                    foreach (var item in listTheoDoiHocKyResult)
                    {
                        TheoDoiHocKy tdhk = new TheoDoiHocKy();
                        tdhk.Id = item.Id;
                        tdhk.Mahk = item.Mahk;
                        tdhk.Tongtc = item.Tongtc;
                        tdhk.Dtbchk = item.Dtbchk;
                        tdhk.Diemrl = item.Diemrl;
                        tdhk.Thoigian = item.Thoigian;
                        tdhk.DeleteDate = item.DeleteDate;
                        tdhk.DeleteUserId = item.DeleteUserId;
                        listTheoDoiHocKy.Add(tdhk);
                    }
                }

                wsi.SinhVien = sinhVien;
                wsi.PhuHuynh = phuHuynh;
                wsi.ChinhSach = chinhsach;
                wsi.Khoa = khoa;
                wsi.Nganh = nganh;
                wsi.LopSinhHoat = lopsinhhoat;
                wsi.TheoDoiHocKys = listTheoDoiHocKy;
                wsi.TinTucSinhViens = listTinTuc;
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            string str = js.Serialize(wsi);
            return str;
        }
    }
}
