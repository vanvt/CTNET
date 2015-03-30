using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class SinhVienEntity
    {
        //
        String masv;
        //
        int macs;
        //
        int maph;
        //
        String malsh;
        //
        String tensv;
        //
        String sodt;
        //
        String email;
        //
        DateTime? ngaysinh;
        //
        String noisinh;
        //
        String noithuongtru;
        //
        String gioitinh;
        //
        String dantoc;
        //
        String tongiao;
        //
        String socmnd;
        //
        String matkhau;
        //
        DateTime? deleteDate;
        //
        int? deleteUserId;
        
        public SinhVienEntity()
        {
        
        }
        
        public virtual String Masv { get { return masv; } set { masv = value; } }
        
        public virtual int Macs { get { return macs; } set { macs = value; } }
        
        public virtual int Maph { get { return maph; } set { maph = value; } }
        
        public virtual String Malsh { get { return malsh; } set { malsh = value; } }
        
        public virtual String Tensv { get { return tensv; } set { tensv = value; } }
        
        public virtual String Sodt { get { return sodt; } set { sodt = value; } }
        
        public virtual String Email { get { return email; } set { email = value; } }
        
        public virtual DateTime? Ngaysinh { get { return ngaysinh; } set { ngaysinh = value; } }
        
        public virtual String Noisinh { get { return noisinh; } set { noisinh = value; } }
        
        public virtual String Noithuongtru { get { return noithuongtru; } set { noithuongtru = value; } }
        
        public virtual String Gioitinh { get { return gioitinh; } set { gioitinh = value; } }
        
        public virtual String Dantoc { get { return dantoc; } set { dantoc = value; } }
        
        public virtual String Tongiao { get { return tongiao; } set { tongiao = value; } }
        
        public virtual String Socmnd { get { return socmnd; } set { socmnd = value; } }
        
        public virtual String Matkhau { get { return matkhau; } set { matkhau = value; } }
        
        public virtual DateTime? DeleteDate { get { return deleteDate; } set { deleteDate = value; } }
        
        public virtual int? DeleteUserId { get { return deleteUserId; } set { deleteUserId = value; } }
        
    }
}
