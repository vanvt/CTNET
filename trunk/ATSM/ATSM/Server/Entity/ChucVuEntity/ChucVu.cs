using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class ChucVu
    {
        //
        int macv;
        //
        String tencv;
        
        public ChucVu()
        {
        
        }
        
        public virtual int Macv { get { return macv; } set { macv = value; } }
        
        public virtual String Tencv { get { return tencv; } set { tencv = value; } }
        
    }
}
