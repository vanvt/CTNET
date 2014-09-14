/** 
 * LoginAdminForm.java
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


package vn.com.fpt.form;


import javax.servlet.http.HttpServletRequest;

import org.apache.struts.action.ActionErrors;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionMapping;
import org.apache.struts.action.ActionMessage;

import vn.com.fpt.bo.LoginAdminBO;

/**
 * Class Action Form for admin login
 * 
 * @author Design Framework Group
 */
@SuppressWarnings("serial")
public class LoginAdminForm extends ActionForm {

	// Variables
	private String account;
	private String password;

	// Getters and setters
	

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		
		this.password = password;
	}

	public String getAccount() {
		return account;
	}

	public void setAccount(String account) {
		this.account = account;
	}
	public ActionErrors validate(ActionMapping mapping,
			HttpServletRequest request) {

		// create a new instance of actionerrors
		ActionErrors actionErrors = new ActionErrors();
	      LoginAdminBO loginBO = new  LoginAdminBO();
	      
		if (!loginBO.checkLoginAdmin(account, password)) {
			actionErrors.add("passwordMessageError", new ActionMessage("error.login"));
		}
		return actionErrors;
	}
}
