using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class User
    {
        //
        int id;
        //
        String password;
        //
        int roleId;
        //
        DateTime insertDate;
        //
        int insertUserId;
        //
        DateTime updateDate;
        //
        int updateUserId;
        //
        DateTime? deleteDate;
        //
        int? deleteUserId;
        
        public User()
        {
        
        }
        
        public virtual int Id { get { return id; } set { id = value; } }
        
        public virtual String Password { get { return password; } set { password = value; } }
        
        public virtual int RoleId { get { return roleId; } set { roleId = value; } }
        
        public virtual DateTime InsertDate { get { return insertDate; } set { insertDate = value; } }
        
        public virtual int InsertUserId { get { return insertUserId; } set { insertUserId = value; } }
        
        public virtual DateTime UpdateDate { get { return updateDate; } set { updateDate = value; } }
        
        public virtual int UpdateUserId { get { return updateUserId; } set { updateUserId = value; } }
        
        public virtual DateTime? DeleteDate { get { return deleteDate; } set { deleteDate = value; } }
        
        public virtual int? DeleteUserId { get { return deleteUserId; } set { deleteUserId = value; } }
        
    }
}
