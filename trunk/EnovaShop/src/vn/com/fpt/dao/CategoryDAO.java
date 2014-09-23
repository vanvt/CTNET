package vn.com.fpt.dao;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;

import vn.com.fpt.bean.Categories;
import vn.com.fpt.exception.DAOException;

public class CategoryDAO {
	private Connection connection = null;
	private CallableStatement callableStatement = null;
	private ResultSet resultSet = null;
	/**
	 * Get Category By Id
	 * @param id
	 * @return
	 * @throws DAOException
	 */
	public Categories getCategoryById(int id) throws DAOException {
		try {
			connection = BaseDAO.getConnection();
			String sql = "{call selectCategoryById(?)}"; // Call store procedure to add new admin account
			callableStatement = connection.prepareCall(sql);
			callableStatement.setInt(1, id);
			resultSet = callableStatement.executeQuery();
			Categories cate = new Categories();
			while(resultSet.next()){
				cate.setCategoryId(resultSet.getInt("CategoryId"));
				cate.setCategoryAlias(resultSet.getString("CategoryAlias"));
				cate.setCategoryName(resultSet.getString("CategoryName"));
				cate.setCategoryParent(resultSet.getInt("CategoryParent"));
				cate.setDescription(resultSet.getString("Description"));
				cate.setHomePublish(resultSet.getString("HomePublic"));
				cate.setPosition(resultSet.getInt("Possition"));
			} 
			return cate;
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
	/**
	 * Get Category By Alias
	 * @param alias
	 * @return
	 * @throws DAOException
	 */
	public Categories getCategoryByAlias(String alias) throws DAOException {
		try {
			connection = BaseDAO.getConnection();
			String sql = "{call selectCategoryByAlias(?)}"; // Call store procedure to add new admin account
			callableStatement = connection.prepareCall(sql);
			callableStatement.setString(1, alias);
			resultSet = callableStatement.executeQuery();
			Categories cate = new Categories();
			while(resultSet.next()){
				cate.setCategoryId(resultSet.getInt("CategoryId"));
				cate.setCategoryAlias(resultSet.getString("CategoryAlias"));
				cate.setCategoryName(resultSet.getString("CategoryName"));
				cate.setCategoryParent(resultSet.getInt("CategoryParent"));
				cate.setDescription(resultSet.getString("Description"));
				cate.setHomePublish(resultSet.getString("HomePublic"));
				cate.setPosition(resultSet.getInt("Possition"));
			} 
			return cate;
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

}