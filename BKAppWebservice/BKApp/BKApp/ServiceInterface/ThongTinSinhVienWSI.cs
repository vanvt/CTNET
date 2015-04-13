using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BKApp
{
    public class ThongTinSinhVienWSI
    {
        //SinhVien
        private SinhVien sinhVien;
        //PhuHuynh
        private PhuHuynh phuHuynh;
        //Khoa
        private Khoa khoa;
        //Nganh
        private Nganh nganh;
        //LopSinhHoat
        private LopSinhHoat lopSinhHoat;
        //ChinhSach
        private ChinhSach chinhSach;
        //TinTucSinhVien
        private List<TinTucSinhVien> tinTucSinhViens;
        //TheoDoiHocKy
        private List<TheoDoiHocKy> theoDoiHocKys;

        public ThongTinSinhVienWSI()
        {
            sinhVien = new SinhVien();
            phuHuynh = new PhuHuynh();
            khoa = new Khoa();
            nganh = new Nganh();
            lopSinhHoat = new LopSinhHoat();
            chinhSach = new ChinhSach();
            tinTucSinhViens = new List<TinTucSinhVien>();
            theoDoiHocKys = new List<TheoDoiHocKy>();
        }

        public SinhVien SinhVien { get { return sinhVien; } set { sinhVien = value; } }

        public PhuHuynh PhuHuynh { get { return phuHuynh; } set { phuHuynh = value; } }

        public Khoa Khoa { get { return khoa; } set { khoa = value; } }

        public Nganh Nganh { get { return nganh; } set { nganh = value; } }

        public LopSinhHoat LopSinhHoat { get { return lopSinhHoat; } set { lopSinhHoat = value; } }

        public ChinhSach ChinhSach { get { return chinhSach; } set { chinhSach = value; } }

        public List<TinTucSinhVien> TinTucSinhViens { get { return tinTucSinhViens; } set { tinTucSinhViens = value; } }

        public List<TheoDoiHocKy> TheoDoiHocKys { get { return theoDoiHocKys; } set { theoDoiHocKys = value; } }
    }
}