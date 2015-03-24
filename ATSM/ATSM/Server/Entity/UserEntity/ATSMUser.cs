using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class ATSMUser
    {
        //
        int id;
        //
        String password;
        
        public ATSMUser()
        {
        
        }
        
        public virtual int Id { get { return id; } set { id = value; } }
        
        public virtual String Password { get { return password; } set { password = value; } }
        
    }
}
