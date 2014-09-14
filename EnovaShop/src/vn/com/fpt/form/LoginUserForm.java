package vn.com.fpt.form;

import org.apache.struts.action.ActionForm;

public class LoginUserForm extends ActionForm{
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private String account;
	private String password;
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
}
