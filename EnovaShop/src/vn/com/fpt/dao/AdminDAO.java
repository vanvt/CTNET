/** 
 * AdminDAO.java
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


package vn.com.fpt.dao;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;

import vn.com.fpt.bean.Admin;
import vn.com.fpt.exception.DAOException;

/**
 * Class to implement Data Access Object of module Admin
 * 
 * @author Design Framework Group
 */
public class AdminDAO {

	/**
	 * Initial variables
	 */
	private Connection connection = null;
	private CallableStatement callableStatement = null;
	private ResultSet resultSet = null;

	/**
	 * Method to add an admin account to database
	 * 
	 * @param admin : Admin bean
	 * @throws DAOException
	 */
	public void addNewAdmin(Admin admin) throws DAOException {
		try {
			connection = BaseDAO.getConnection();
			String sql = "{call addNewAdmin(?,?)}"; // Call store procedure to add new admin account
			callableStatement = connection.prepareCall(sql);
			callableStatement.setString(1, admin.getUsername());
			callableStatement.setString(2, admin.getPassword());
			callableStatement.execute();
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		} finally {
			try {
				if (callableStatement != null)
					callableStatement.close();
				if (connection != null)
					connection.close();
			} catch (SQLException e) {
				throw new DAOException(e.getMessage());
			}
		}
	}

	/**
	 * Method to check if an admin account is valid or not
	 * 
	 * @param admin : Admin bean
	 * @return a boolean value indicates whether or not the admin account is
	 *         valid
	 * @throws DAOException
	 */
	public boolean isValidAccount(Admin admin) throws DAOException {
		try {
			connection = BaseDAO.getConnection();
			String sql = "{call isValidLoginAdmin(?,?)}"; // Call store procedure to check if an admin account is valid
			callableStatement = connection.prepareCall(sql);
			callableStatement.setString(1, admin.getUsername());
			callableStatement.setString(2, admin.getPassword());
			resultSet = callableStatement.executeQuery();

			/*
			 * Process the result string If it is "1", the admin is valid,
			 * return true Otherwise, return false
			 */
			if (resultSet.next()) {
				if (resultSet.getString("Result").trim().equals("1")) {
					return true;
				}
			}
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		} finally {
			try {
				if (resultSet != null)
					resultSet.close();
				if (callableStatement != null)
					callableStatement.close();
				if (connection != null)
					connection.close();
			} catch (SQLException e) {
				throw new DAOException(e.getMessage());
			}
		}
		return false;
	}
}
