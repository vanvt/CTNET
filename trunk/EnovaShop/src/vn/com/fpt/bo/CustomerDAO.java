package vn.com.fpt.dao;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;

import vn.com.fpt.exception.DAOException;

public class CustomerDAO {
	private Connection connection = null;
	private CallableStatement callableStatement = null;


	public void register(String customerAccount, String customerName,
			String gender, String email, String password, String phone,
			String address, String city) {
		// TODO Auto-generated method stub
		try {
			connection = BaseDAO.getConnection();
			String sql = "{call insertCustomer(?,?,?,?,?,?,?,?)}"; // Call store procedure to add new admin account
			callableStatement = connection.prepareCall(sql);
			callableStatement.setString(1, customerAccount);
			callableStatement.setString(2, customerName);
			callableStatement.setBoolean(3, true);
			callableStatement.setString(4, email);
			callableStatement.setString(5, password);
			callableStatement.setString(6, phone);
			callableStatement.setString(7, address);
			callableStatement.setString(8, city);
			
			callableStatement.execute();
		} catch (SQLException e) {
			try {
				throw new DAOException(e.getMessage());
			} catch (DAOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		} catch (DAOException e) {
			try {
				throw new DAOException(e.getMessage());
			} catch (DAOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		} finally {
			try {
				if (callableStatement != null)
					callableStatement.close();
				if (connection != null)
					connection.close();
			} catch (SQLException e) {
				try {
					throw new DAOException(e.getMessage());
				} catch (DAOException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		}
	}

}
