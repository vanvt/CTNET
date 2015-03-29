using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace JVL
{
    public class TinTucDaoTaoWSI
    {
        //TinTucDaoTao
        private List<TinTucDaoTao> tinTucDaoTao;
        //TheLoaiTin
        private List<TheLoaiTin> theLoaiTin;
        //CanBoGiaoVIen
        private List<CanBoGiaoVien> canBoGiaoVien;
        //ChucVu
        private List<ChucVu> chucVu;
        //return true if is error else empty
        private String isWsiError;
        //return error list
        private ArrayList wsiError;
        //SAV:save object,DEL:delete object,SEL:get object,SRC:search object
        private String mode;
        
        public TinTucDaoTaoWSI()
        {
            tinTucDaoTao = new List<TinTucDaoTao>();
            theLoaiTin = new List<TheLoaiTin>();
            canBoGiaoVien = new List<CanBoGiaoVien>();
            chucVu = new List<ChucVu>();
            isWsiError = String.Empty;
            wsiError = new ArrayList();
            mode = String.Empty;
        }
        
        public List<TinTucDaoTao> TinTucDaoTao { get { return tinTucDaoTao; } set { tinTucDaoTao = value; } }
        
        public List<TheLoaiTin> TheLoaiTin { get { return theLoaiTin; } set { theLoaiTin = value; } }
        
        public List<CanBoGiaoVien> CanBoGiaoVien { get { return canBoGiaoVien; } set { canBoGiaoVien = value; } }
        
        public List<ChucVu> ChucVu { get { return chucVu; } set { chucVu = value; } }
        
        public String IsWsiError { get { return isWsiError; } set { isWsiError = value; } }
        
        public ArrayList WsiError { get { return wsiError; } set { wsiError = value; } }
        
        public String Mode { get { return mode; } set { mode = value; } }
        
    }
}
