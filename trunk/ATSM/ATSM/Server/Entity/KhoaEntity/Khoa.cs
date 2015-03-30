using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class Khoa
    {
        //
        String makhoa;
        //
        String tenkhoa;
        
        public Khoa()
        {
        
        }
        
        public virtual String Makhoa { get { return makhoa; } set { makhoa = value; } }
        
        public virtual String Tenkhoa { get { return tenkhoa; } set { tenkhoa = value; } }
        
    }
}
