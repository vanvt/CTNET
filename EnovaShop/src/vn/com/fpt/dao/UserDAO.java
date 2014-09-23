package vn.com.fpt.dao;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;

import vn.com.fpt.bean.UserManager;
import vn.com.fpt.exception.DAOException;

public class UserDAO {
	private Connection connection = null;
	private CallableStatement callableStatement = null;
	private ResultSet resultSet = null;
	
	public UserManager getUserByUserName(String username) throws DAOException{
		// TODO Auto-generated method stub
		try {
			connection = BaseDAO.getConnection();
			String sql="{call selectUserManager(?)}";
			callableStatement = connection.prepareCall(sql);
			callableStatement.setString(1, username);
			resultSet = callableStatement.executeQuery();
			UserManager userManager = null;
			while (resultSet.next()) {
				userManager = new UserManager();
				userManager.setEmail(resultSet.getString("Email"));
				userManager.setFullName(resultSet.getString("FullName"));
				userManager.setPassword(resultSet.getString("Password"));
				userManager.setPermission(resultSet.getString("Permission"));
				userManager.setUserName(resultSet.getString("UserName"));
			}
			return userManager;
			
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		} finally {
			try {
				if (resultSet!=null) resultSet.close();
				if (callableStatement != null)	callableStatement.close();
				if (connection != null)	connection.close();
			} catch (SQLException e) {
				throw new DAOException(e.getMessage());
			}
		}
	}

	public void insertUser(UserManager userManager) throws DAOException{
		// TODO Auto-generated method stub
		try {
			connection = BaseDAO.getConnection();
			String sql = "{call insertUserManager(?,?,?,?,?)}";
			callableStatement = connection.prepareCall(sql);
			callableStatement.setString(1, userManager.getUserName());
			callableStatement.setString(2, userManager.getEmail());
			callableStatement.setString(3, userManager.getPassword());
			callableStatement.setString(4, userManager.getPermission());
			callableStatement.setString(5, userManager.getFullName());
			callableStatement.execute();
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		} finally {
			try {
				if (callableStatement != null)	callableStatement.close();
				if (connection != null)	connection.close();
			} catch (SQLException e) {
				throw new DAOException(e.getMessage());
			}
		}
	}

	public void updateUser(UserManager userManager) throws DAOException{
		// TODO Auto-generated method stub
		try {
			connection = BaseDAO.getConnection();
			String sql = "{call updateUserManager(?,?,?,?,?)}";
			callableStatement = connection.prepareCall(sql);
			callableStatement.setString(1, userManager.getUserName());
			callableStatement.setString(2, userManager.getEmail());
			callableStatement.setString(3, userManager.getPassword());
			callableStatement.setString(4, userManager.getPermission());
			callableStatement.setString(5, userManager.getFullName());
			callableStatement.execute();
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		} finally {
			try {
				if (callableStatement != null)	callableStatement.close();
				if (connection != null)	connection.close();
			} catch (SQLException e) {
				throw new DAOException(e.getMessage());
			}
		}
	}

	public void removeUser(String userName) throws DAOException{
		// TODO Auto-generated method stub
		try {
			connection = BaseDAO.getConnection();
			String sql ="{call deleteUserManager(?)}";
			callableStatement = connection.prepareCall(sql);
			callableStatement.setString(1, userName);
			callableStatement.executeUpdate();
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		} finally {
			try {
				if (callableStatement != null)	callableStatement.close();
				if (connection != null)	connection.close();
			} catch (SQLException e) {
				throw new DAOException(e.getMessage());
			}
		}
	}
	
	
	/*
	 * insert userManager
	 */
	
	}
