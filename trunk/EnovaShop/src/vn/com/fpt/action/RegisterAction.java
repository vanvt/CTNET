package vn.com.fpt.action;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.struts.action.Action;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionForward;
import org.apache.struts.action.ActionMapping;

import vn.com.fpt.bo.CustomerBO;
import vn.com.fpt.form.RegisterForm;

public class RegisterAction  extends Action{
	public ActionForward execute(ActionMapping mapping, ActionForm form,
	        HttpServletRequest request, HttpServletResponse response){
		RegisterForm registerForm = (RegisterForm) form;
		CustomerBO customerBO = new CustomerBO();
		customerBO.register(registerForm.getCustomerAccount(),registerForm.getCustomerName(),registerForm.getGender(),
				registerForm.getEmail(),registerForm.getPassword(),registerForm.getPhone(),registerForm.getAddress(),registerForm.getCity());
		return mapping.findForward("attendance");
		
	}
}
