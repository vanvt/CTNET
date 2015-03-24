using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace JVL
{
    public class UserWSI
    {
        //MrpCombo class type
        private ATSMUser aTSMUser;
        //return true if is error else empty
        private String isWsiError;
        //return error list
        private ArrayList wsiError;
        //SAV:save object,DEL:delete object,SEL:get object,SRC:search object
        private String mode;
        
        public UserWSI()
        {
            aTSMUser = new ATSMUser();
            isWsiError = String.Empty;
            wsiError = new ArrayList();
            mode = String.Empty;
        }
        
        public ATSMUser ATSMUser { get { return aTSMUser; } set { aTSMUser = value; } }
        
        public String IsWsiError { get { return isWsiError; } set { isWsiError = value; } }
        
        public ArrayList WsiError { get { return wsiError; } set { wsiError = value; } }
        
        public String Mode { get { return mode; } set { mode = value; } }
        
    }
}
