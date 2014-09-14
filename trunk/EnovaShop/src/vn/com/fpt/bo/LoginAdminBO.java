package vn.com.fpt.bo;

import vn.com.fpt.dao.LoginAdminDAO;

public class LoginAdminBO {
	public boolean checkLoginAdmin(String Account, String Password) {
		LoginAdminDAO loginAdminDAO = new LoginAdminDAO();
		return loginAdminDAO.checkLoginAdmin(Account, Password);
	}
}
