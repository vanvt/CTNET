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

import vn.com.fpt.bean.Admin;
import vn.com.fpt.dao.AdminDAO;
import vn.com.fpt.exception.DAOException;



/**
 * Class to implement business logic of module Admin
 * 
 * @author Design Framework Group
 */
public class AdminBO {

	private AdminDAO adminDAO = new AdminDAO(); // An instance of class AdminDAO to use in all method of this class

	/**
	 * Method to add new admin account to database
	 * Call method addNewAdmin(Admin) of class AdminDAO
	 * 
	 * @param admin : Admin bean
	 * @throws DAOException
	 */
	public void addNewAdmin(Admin admin) throws DAOException {
		try {
			adminDAO.addNewAdmin(admin);
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		}
	}

	/**
	 * Method to check if an admin account is valid
	 * Call method isValidAccount(Admin) of class AdminDAO
	 * 
	 * @param admin
	 * @return boolean value express whether or not an admin account is valid
	 * @throws DAOException
	 */
	public boolean isValidAccount(Admin admin) throws DAOException {
		try {
			return adminDAO.isValidAccount(admin);
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		}
	}
}
