using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class LoginUser
    {
        //
        String loginUserId;
        //
        String password;
        //
        DateTime insertDate;
        //
        DateTime updateDate;
        //
        DateTime? deleteDate;
        //
        int? deleteUserId;
        //
        String newPassword;
        //
        int status;
        
        public LoginUser()
        {
        
        }
        
        public virtual String LoginUserId { get { return loginUserId; } set { loginUserId = value; } }
        
        public virtual String Password { get { return password; } set { password = value; } }
        
        public virtual DateTime InsertDate { get { return insertDate; } set { insertDate = value; } }
        
        public virtual DateTime UpdateDate { get { return updateDate; } set { updateDate = value; } }
        
        public virtual DateTime? DeleteDate { get { return deleteDate; } set { deleteDate = value; } }
        
        public virtual int? DeleteUserId { get { return deleteUserId; } set { deleteUserId = value; } }
        
        public virtual String NewPassword { get { return newPassword; } set { newPassword = value; } }
        
        public virtual int Status { get { return status; } set { status = value; } }
        
    }
}
