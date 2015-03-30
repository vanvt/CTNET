using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class ChiTietLopHocPhan
    {
        //
        int id;
        //
        String malhp;
        //
        int? thu;
        //
        int? tutiet;
        //
        int? dentiet;
        //
        String phong;
        //
        DateTime? deleteDate;
        //
        int? deleteUserId;
        
        public ChiTietLopHocPhan()
        {
        
        }
        
        public virtual int Id { get { return id; } set { id = value; } }
        
        public virtual String Malhp { get { return malhp; } set { malhp = value; } }
        
        public virtual int? Thu { get { return thu; } set { thu = value; } }
        
        public virtual int? Tutiet { get { return tutiet; } set { tutiet = value; } }
        
        public virtual int? Dentiet { get { return dentiet; } set { dentiet = value; } }
        
        public virtual String Phong { get { return phong; } set { phong = value; } }
        
        public virtual DateTime? DeleteDate { get { return deleteDate; } set { deleteDate = value; } }
        
        public virtual int? DeleteUserId { get { return deleteUserId; } set { deleteUserId = value; } }
        
    }
}
