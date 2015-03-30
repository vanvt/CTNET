using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class HocPhan
    {
        //
        String mahp;
        //
        String tenhp;
        //
        int? sotc;
        //
        int? lythuyet;
        //
        int? thuchanhbt;
        //
        int doan;
        //
        String moTa;
        //
        String ghichu;
        //
        DateTime? deleteDate;
        //
        int? deleteUserId;
        
        public HocPhan()
        {
        
        }
        
        public virtual String Mahp { get { return mahp; } set { mahp = value; } }
        
        public virtual String Tenhp { get { return tenhp; } set { tenhp = value; } }
        
        public virtual int? Sotc { get { return sotc; } set { sotc = value; } }
        
        public virtual int? Lythuyet { get { return lythuyet; } set { lythuyet = value; } }
        
        public virtual int? Thuchanhbt { get { return thuchanhbt; } set { thuchanhbt = value; } }
        
        public virtual int Doan { get { return doan; } set { doan = value; } }
        
        public virtual String MoTa { get { return moTa; } set { moTa = value; } }
        
        public virtual String Ghichu { get { return ghichu; } set { ghichu = value; } }
        
        public virtual DateTime? DeleteDate { get { return deleteDate; } set { deleteDate = value; } }
        
        public virtual int? DeleteUserId { get { return deleteUserId; } set { deleteUserId = value; } }
        
    }
}
