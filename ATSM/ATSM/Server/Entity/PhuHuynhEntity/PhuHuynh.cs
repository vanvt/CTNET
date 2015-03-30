using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class PhuHuynh
    {
        //
        int maph;
        //
        String hotencha;
        //
        String nghenghiepcha;
        //
        String hotenme;
        //
        String nghenghiepme;
        //
        String diachi;
        //
        String sodienthoai;
        //
        String email;
        //
        DateTime? deleteDate;
        //
        int? deleteUserId;
        
        public PhuHuynh()
        {
        
        }
        
        public virtual int Maph { get { return maph; } set { maph = value; } }
        
        public virtual String Hotencha { get { return hotencha; } set { hotencha = value; } }
        
        public virtual String Nghenghiepcha { get { return nghenghiepcha; } set { nghenghiepcha = value; } }
        
        public virtual String Hotenme { get { return hotenme; } set { hotenme = value; } }
        
        public virtual String Nghenghiepme { get { return nghenghiepme; } set { nghenghiepme = value; } }
        
        public virtual String Diachi { get { return diachi; } set { diachi = value; } }
        
        public virtual String Sodienthoai { get { return sodienthoai; } set { sodienthoai = value; } }
        
        public virtual String Email { get { return email; } set { email = value; } }
        
        public virtual DateTime? DeleteDate { get { return deleteDate; } set { deleteDate = value; } }
        
        public virtual int? DeleteUserId { get { return deleteUserId; } set { deleteUserId = value; } }
        
    }
}
