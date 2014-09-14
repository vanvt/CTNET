/** 
 * DBConnection.java
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

import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

import vn.com.fpt.common.Common;
import vn.com.fpt.exception.DAOException;


/**
 * Create connection to database
 * 
 * @author Design Framework Group
 */
public class BaseDAO {

	/**
	 * Method to create connection to database
	 * 
	 * @return Connection instance that is connected to desired database
	 * @throws DBConnectionException
	 * @throws ClassNotFoundException
	 * @throws SQLException
	 * @throws IOException
	 */
	public static Connection getConnection() throws DAOException {
		try {
			// Get driver class
			Class.forName(Common.getProperty("driver"));

			// Get login info from Common file
			String server = Common.getProperty("server");
			String port = Common.getProperty("port");
			String databaseName = Common.getProperty("databaseName");
			String userName = Common.getProperty("userName");
			String password = Common.getProperty("password");
			String url = "jdbc:sqlserver://" + server + ":" + port
			        + ";databaseName=" + databaseName; // Create url

			// Return connection
			return DriverManager.getConnection(url, userName,
			        password);
		} catch (ClassNotFoundException e) {
			throw new DAOException(e.getMessage());
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (IOException e) {
			throw new DAOException(e.getMessage());
		}
    }
}