using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BKApp
{
    public class TinTucDaoTaoWSI
    {
        List<TinTucDaoTao> tinTucDaoTao;
        List<CanBoGiaoVien> canBoGiaoVien;
        List<TheLoaiTin> theLoaiTin;

        public List<TinTucDaoTao> TinTucDaoTao
        {
            get
            {
                return tinTucDaoTao;
            }
            set
            {
                tinTucDaoTao = value;
            }
        }
        public List<CanBoGiaoVien> CanBoGiaoVien
        {
            get
            {
                return canBoGiaoVien;
            }
            set
            {
                canBoGiaoVien = value;
            }
        }
        public List<TheLoaiTin> TheLoaiTin
        {
            get
            {
                return theLoaiTin;
            }
            set
            {
                theLoaiTin = value;
            }
        }

    }
}