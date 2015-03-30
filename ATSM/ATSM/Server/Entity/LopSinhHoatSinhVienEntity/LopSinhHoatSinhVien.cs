using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class LopSinhHoatSinhVien
    {
        //
        int id;
        //
        String malsh;
        //
        String masv;
        //
        int sotctl;
        //
        Double dtbctl;
        //
        DateTime? deleteDate;
        //
        int? deleteUserId;
        
        public LopSinhHoatSinhVien()
        {
        
        }
        
        public virtual int Id { get { return id; } set { id = value; } }
        
        public virtual String Malsh { get { return malsh; } set { malsh = value; } }
        
        public virtual String Masv { get { return masv; } set { masv = value; } }
        
        public virtual int Sotctl { get { return sotctl; } set { sotctl = value; } }
        
        public virtual Double Dtbctl { get { return dtbctl; } set { dtbctl = value; } }
        
        public virtual DateTime? DeleteDate { get { return deleteDate; } set { deleteDate = value; } }
        
        public virtual int? DeleteUserId { get { return deleteUserId; } set { deleteUserId = value; } }
        
    }
}
