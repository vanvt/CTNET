using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class LopSinhHoatEntity
    {
        //
        String malsh;
        //
        String manganh;
        //
        String macbgv;
        //
        String tenlsh;
        //
        int siso;
        //
        int khoa;
        //
        DateTime? deleteDate;
        //
        int? deleteUserId;
        
        public LopSinhHoatEntity()
        {
        
        }
        
        public virtual String Malsh { get { return malsh; } set { malsh = value; } }
        
        public virtual String Manganh { get { return manganh; } set { manganh = value; } }
        
        public virtual String Macbgv { get { return macbgv; } set { macbgv = value; } }
        
        public virtual String Tenlsh { get { return tenlsh; } set { tenlsh = value; } }
        
        public virtual int Siso { get { return siso; } set { siso = value; } }
        
        public virtual int Khoa { get { return khoa; } set { khoa = value; } }
        
        public virtual DateTime? DeleteDate { get { return deleteDate; } set { deleteDate = value; } }
        
        public virtual int? DeleteUserId { get { return deleteUserId; } set { deleteUserId = value; } }
        
    }
}
