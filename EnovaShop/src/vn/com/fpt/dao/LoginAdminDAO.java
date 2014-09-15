package vn.com.fpt.dao;

import java.io.UnsupportedEncodingException;
import java.security.NoSuchAlgorithmException;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;

import vn.com.fpt.common.Common;
import vn.com.fpt.exception.DAOException;

public class LoginAdminDAO {
	public boolean 	checkLoginAdmin(String Account, String Password){
		ResultSet result = null;
		Common common = new Common();
		try {
			Password = common.encryptPassword(Password);
		} catch (NoSuchAlgorithmException | UnsupportedEncodingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		try{
		Connection con;			
		con = BaseDAO.getConnection();
		String CheckLogin = "{call login_admin(?,?)}";
		CallableStatement  callableStatement = con.prepareCall(CheckLogin);
		callableStatement.setString(1,Account );
		callableStatement.setString(2, Password);	
		result = callableStatement.executeQuery();
		if (result.next()) {
			return true;
		}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}catch (DAOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return false;
		
	}
}