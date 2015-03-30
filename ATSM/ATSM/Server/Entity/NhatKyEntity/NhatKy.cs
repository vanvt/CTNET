using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class NhatKy
    {
        //
        int mank;
        //
        String malhp;
        //
        String macbgv;
        //
        String tacvu;
        //
        String lydo;
        //
        DateTime thoigian;
        //
        DateTime? deleteDate;
        //
        int? deleteUserId;
        
        public NhatKy()
        {
        
        }
        
        public virtual int Mank { get { return mank; } set { mank = value; } }
        
        public virtual String Malhp { get { return malhp; } set { malhp = value; } }
        
        public virtual String Macbgv { get { return macbgv; } set { macbgv = value; } }
        
        public virtual String Tacvu { get { return tacvu; } set { tacvu = value; } }
        
        public virtual String Lydo { get { return lydo; } set { lydo = value; } }
        
        public virtual DateTime Thoigian { get { return thoigian; } set { thoigian = value; } }
        
        public virtual DateTime? DeleteDate { get { return deleteDate; } set { deleteDate = value; } }
        
        public virtual int? DeleteUserId { get { return deleteUserId; } set { deleteUserId = value; } }
        
    }
}
