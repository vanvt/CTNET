/** 
 * AdminBO.java
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


package vn.com.fpt.bo;

import vn.com.fpt.bean.UserManager;
import vn.com.fpt.dao.UserDAO;
import vn.com.fpt.exception.DAOException;




/**
 * Class to implement business logic of module Admin
 * 
 * @author Design Framework Group
 */
public class UserBO {
	UserDAO userDAO = new UserDAO();
	
	public void insertUser(UserManager userManager) throws DAOException {
		userDAO.insertUser(userManager);
	}
	
	public void updateUser(UserManager userManager) throws DAOException {
		userDAO.updateUser(userManager);
		
	}
	
	public void removeUser(String userName) throws DAOException {
		userDAO.removeUser(userName);
	}
}
