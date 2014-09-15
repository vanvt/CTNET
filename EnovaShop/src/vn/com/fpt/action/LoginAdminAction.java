/** 
 * LoginAdminAction.java
 * 
 * 1.2
 * 
 * 18/03/2013
 * 
 * Copyright (c) 2013 FPT Software.
 * FPT Building, Street No1, DaNang Industrial Zone, AnDon, 
 * AnHaiBac Ward, SonTra District, DaNang City.
 * All rights reserved.
 */


package vn.com.fpt.action;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.struts.action.Action;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionForward;
import org.apache.struts.action.ActionMapping;

import vn.com.fpt.bo.LoginAdminBO;
import vn.com.fpt.form.LoginAdminForm;

/**
 * Class to implement the action loginAdmin
 * 
 * @author Design Framework Group
 */
public class LoginAdminAction extends Action {

/*	private static Logger logger = Logger.getLogger(LoginAdminAction.class); // Call the logger of log4j to use the class as an instance to log

	*//**
	 * Method execute, called when executing the action
	 * 
	 * @param mapping
	 * @param form
	 * @param request
	 * @param response
	 */
	
	public ActionForward execute(ActionMapping mapping, ActionForm form,
	        HttpServletRequest request, HttpServletResponse response){
		LoginAdminForm loginUserForm = (LoginAdminForm) form;
		
		LoginAdminBO adminBO = new LoginAdminBO();
		if(adminBO.checkLoginAdmin(loginUserForm.getAccount(), loginUserForm.getPassword())){
			return mapping.findForward("success");
		}
		return mapping.findForward("fail");
		
	}
}
