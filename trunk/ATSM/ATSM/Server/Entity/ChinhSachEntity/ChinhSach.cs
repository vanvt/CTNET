using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class ChinhSach
    {
        //
        int macs;
        //
        String tencs;
        
        public ChinhSach()
        {
        
        }
        
        public virtual int Macs { get { return macs; } set { macs = value; } }
        
        public virtual String Tencs { get { return tencs; } set { tencs = value; } }
        
    }
}
