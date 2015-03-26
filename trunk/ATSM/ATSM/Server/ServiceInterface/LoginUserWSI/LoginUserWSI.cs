using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace JVL
{
    public class LoginUserWSI
    {
        //LoginUserEntity
        private LoginUser loginUser;
        //return true if is error else empty
        private String isWsiError;
        //return error list
        private ArrayList wsiError;
        //SAV:save object,DEL:delete object,SEL:get object,SRC:search object
        private String mode;
        
        public LoginUserWSI()
        {
            loginUser = new LoginUser();
            isWsiError = String.Empty;
            wsiError = new ArrayList();
            mode = String.Empty;
        }

        public LoginUser LoginUser { get { return loginUser; } set { loginUser = value; } }
        
        public String IsWsiError { get { return isWsiError; } set { isWsiError = value; } }
        
        public ArrayList WsiError { get { return wsiError; } set { wsiError = value; } }
        
        public String Mode { get { return mode; } set { mode = value; } }
        
    }
}
