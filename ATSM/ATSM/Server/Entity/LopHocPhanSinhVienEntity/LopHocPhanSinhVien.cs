using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class LopHocPhanSinhVien
    {
        //
        int id;
        //
        String masv;
        //
        String malhp;
        //
        Double? dtkgk;
        //
        Double? dtkck;
        //
        Double? dtkhp;
        //
        Double? dcc;
        //
        bool? tichluy;
        //
        String ghichu;
        //
        DateTime? deleteDate;
        //
        int? deleteUserId;
        
        public LopHocPhanSinhVien()
        {
        
        }
        
        public virtual int Id { get { return id; } set { id = value; } }
        
        public virtual String Masv { get { return masv; } set { masv = value; } }
        
        public virtual String Malhp { get { return malhp; } set { malhp = value; } }
        
        public virtual Double? Dtkgk { get { return dtkgk; } set { dtkgk = value; } }
        
        public virtual Double? Dtkck { get { return dtkck; } set { dtkck = value; } }
        
        public virtual Double? Dtkhp { get { return dtkhp; } set { dtkhp = value; } }
        
        public virtual Double? Dcc { get { return dcc; } set { dcc = value; } }
        
        public virtual bool? Tichluy { get { return tichluy; } set { tichluy = value; } }
        
        public virtual String Ghichu { get { return ghichu; } set { ghichu = value; } }
        
        public virtual DateTime? DeleteDate { get { return deleteDate; } set { deleteDate = value; } }
        
        public virtual int? DeleteUserId { get { return deleteUserId; } set { deleteUserId = value; } }
        
    }
}
