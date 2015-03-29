using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class TheLoaiTin
    {
        //
        int matlt;
        //
        String tentlt;
        
        public TheLoaiTin()
        {
        
        }
        
        public virtual int Matlt { get { return matlt; } set { matlt = value; } }
        
        public virtual String Tentlt { get { return tentlt; } set { tentlt = value; } }
        
    }
}
