using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class CanBoGiaoVien
    {
        //
        String macbgv;
        //
        int? macv;
        //
        String tencbgv;
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
        
        public CanBoGiaoVien()
        {
        
        }
        
        public virtual String Macbgv { get { return macbgv; } set { macbgv = value; } }
        
        public virtual int? Macv { get { return macv; } set { macv = value; } }
        
        public virtual String Tencbgv { get { return tencbgv; } set { tencbgv = value; } }
        
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
