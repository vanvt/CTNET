using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class Nganh
    {
        //
        String manganh;
        //
        String tennganh;
        //
        int? sotcdc;
        //
        int? sotcbb;
        //
        int? sotctc;
        //
        String moTa;
        //
        String makhoa;
        
        public Nganh()
        {
        
        }
        
        public virtual String Manganh { get { return manganh; } set { manganh = value; } }
        
        public virtual String Tennganh { get { return tennganh; } set { tennganh = value; } }
        
        public virtual int? Sotcdc { get { return sotcdc; } set { sotcdc = value; } }
        
        public virtual int? Sotcbb { get { return sotcbb; } set { sotcbb = value; } }
        
        public virtual int? Sotctc { get { return sotctc; } set { sotctc = value; } }
        
        public virtual String MoTa { get { return moTa; } set { moTa = value; } }
        
        public virtual String Makhoa { get { return makhoa; } set { makhoa = value; } }
        
    }
}
