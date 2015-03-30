using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class LopHocPhan
    {
        //
        String malhp;
        //
        String mahp;
        //
        String macbgv;
        //
        String mahk;
        //
        int soluong;
        //
        int soluongdk;
        //
        DateTime? ngaybatdau;
        //
        DateTime? ngaythi;
        //
        String giothi;
        //
        DateTime ngaynopdiem;
        //
        String ghichu;
        //
        DateTime? deleteDate;
        //
        int? deleteUserId;
        
        public LopHocPhan()
        {
        
        }
        
        public virtual String Malhp { get { return malhp; } set { malhp = value; } }
        
        public virtual String Mahp { get { return mahp; } set { mahp = value; } }
        
        public virtual String Macbgv { get { return macbgv; } set { macbgv = value; } }
        
        public virtual String Mahk { get { return mahk; } set { mahk = value; } }
        
        public virtual int Soluong { get { return soluong; } set { soluong = value; } }
        
        public virtual int Soluongdk { get { return soluongdk; } set { soluongdk = value; } }
        
        public virtual DateTime? Ngaybatdau { get { return ngaybatdau; } set { ngaybatdau = value; } }
        
        public virtual DateTime? Ngaythi { get { return ngaythi; } set { ngaythi = value; } }
        
        public virtual String Giothi { get { return giothi; } set { giothi = value; } }
        
        public virtual DateTime Ngaynopdiem { get { return ngaynopdiem; } set { ngaynopdiem = value; } }
        
        public virtual String Ghichu { get { return ghichu; } set { ghichu = value; } }
        
        public virtual DateTime? DeleteDate { get { return deleteDate; } set { deleteDate = value; } }
        
        public virtual int? DeleteUserId { get { return deleteUserId; } set { deleteUserId = value; } }
        
    }
}
