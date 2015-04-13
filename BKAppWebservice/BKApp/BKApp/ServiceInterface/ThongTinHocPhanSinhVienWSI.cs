using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace BKApp
{
    public class ThongTinHocPhanSinhVienWSI
    {
        //
        private SinhVien sinhVien;
        //
        private List<LopHocPhanSinhVien> lopHocPhanSinhViens;
        //
        private List<LopHocPhan> lopHocPhans;
        //
        private List<HocPhan> hocPhans;
        //
        private List<ChiTietLopHocPhan> chiTietLopHocPhan;
        
        public ThongTinHocPhanSinhVienWSI()
        {
            sinhVien = new SinhVien();
            lopHocPhanSinhViens = new List<LopHocPhanSinhVien>();
            lopHocPhans = new List<LopHocPhan>();
            hocPhans = new List<HocPhan>();
            chiTietLopHocPhan = new List<ChiTietLopHocPhan>();
        }
        
        public SinhVien SinhVien { get { return sinhVien; } set { sinhVien = value; } }
        
        public List<LopHocPhanSinhVien> LopHocPhanSinhViens { get { return lopHocPhanSinhViens; } set { lopHocPhanSinhViens = value; } }
        
        public List<LopHocPhan> LopHocPhans { get { return lopHocPhans; } set { lopHocPhans = value; } }
        
        public List<HocPhan> HocPhans { get { return hocPhans; } set { hocPhans = value; } }
        
        public List<ChiTietLopHocPhan> ChiTietLopHocPhan { get { return chiTietLopHocPhan; } set { chiTietLopHocPhan = value; } }
        
    }
}
