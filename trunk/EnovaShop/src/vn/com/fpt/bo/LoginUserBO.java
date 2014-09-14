package vn.com.fpt.bo;

import vn.com.fpt.dao.LoginUserDAO;

public class LoginUserBO {
	public boolean checkLogin(String Account, String Password) {
		LoginUserDAO loginUserDAO = new LoginUserDAO();
		return loginUserDAO.checkLogin(Account, Password);
	}
}
