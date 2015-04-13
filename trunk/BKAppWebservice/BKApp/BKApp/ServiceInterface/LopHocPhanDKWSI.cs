using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BKApp
{
    public class LopHocPhanDKWSI
    {
        //List Lop Hoc Phan
        private List<LopHocPhan> lopHocPhans;
        //List Hoc Phan
        private List<HocPhan> hocPhans;
        //List Chi Tiet Lop Hoc Phan
        private List<ChiTietLopHocPhan> chiTietLopHocPhans;
        //List Can Bo Giao Vien
        private List<CanBoGiaoVien> canBoGiaoViens;
        //List Hoc Ky
        private List<HocKy> hocKys;
        
        public LopHocPhanDKWSI()
        {
            lopHocPhans = new List<LopHocPhan>();
            hocPhans = new List<HocPhan>();
            chiTietLopHocPhans = new List<ChiTietLopHocPhan>();
            canBoGiaoViens = new List<CanBoGiaoVien>();
            hocKys = new List<HocKy>();
        }
        
        public List<LopHocPhan> LopHocPhans { get { return lopHocPhans; } set { lopHocPhans = value; } }
        
        public List<HocPhan> HocPhans { get { return hocPhans; } set { hocPhans = value; } }
        
        public List<ChiTietLopHocPhan> ChiTietLopHocPhans { get { return chiTietLopHocPhans; } set { chiTietLopHocPhans = value; } }
        
        public List<CanBoGiaoVien> CanBoGiaoViens { get { return canBoGiaoViens; } set { canBoGiaoViens = value; } }
        
        public List<HocKy> HocKys { get { return hocKys; } set { hocKys = value; } }
    }
}